#include<iostream>
using namespace std;

class MyString
{
    public:
        int m_size;
        char* m_nums;
        MyString(int enterSize, const char* enterNums):m_size(enterSize)
        {
            m_nums=new char[enterSize+1];
            for (int i = 0; i < enterSize; i++)
                m_nums[i]=enterNums[i];   
        }
        ~MyString(){};
        
        void Print()
        {
            for (int i = 0; i < m_size; i++)
            {
                cout<<m_nums[i];
            }   
        }

        int Count(char c)
        {
            int count=0;
            for (int i = 0; i < m_size; i++)
            {
                if(m_nums[i]==c)
                    count++;
            }
            return count;
        }

        void append(char c)
        {
            resize(m_size+1);
            m_nums[m_size-1]=c;
        }

        void pop()
        {
            char* newString=new char[m_size-1];
            for (int i = 0; i < m_size-1; i++)
            {
                newString[i]=m_nums[i];
            }
            delete[]m_nums;
            m_nums=newString;
            m_size=m_size-1;
            
        }

        char* reverse()
        {
            char* newString=new char[m_size];
            for (int i = 0; i<m_size; i++)
            {
                newString[i]=m_nums[m_size-1-i];
            }
            return newString;
        }
        private:

            void resize(int newsize)
            {
                char* newString=new char[newsize];
                for (int i = 0; i < m_size; i++)
                {
                    newString[i]=m_nums[i];
                }
                delete[]m_nums;
                m_nums=newString;
                m_size=newsize;  
            }
};
int main()
{
    MyString S(12,"Parnya Azimi");
    S.Print();
    cout<<'\n';
    // cout<<'\n'<<(S.Count('a'));
    // S.Print();
    // cout<<'\n';
    // S.pop();
    // S.Print();
    char* out=S.reverse();
    for (int i = 0; i < S.m_size; i++)
    {
        cout<<out[i];
    }      

}