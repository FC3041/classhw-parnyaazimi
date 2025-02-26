#include <iostream>

using namespace std;

class MyVector
{
    public:
        //1,3,7
        int m_size;
        int m_capasity=m_size*2;
        int* m_nums;

        MyVector(int size, int* nums):m_size(size)
        {
            m_nums= new int[m_capasity];
            for (int i = 0; i < m_size; i++)
                m_nums[i]=nums[i];
        }
        

        //2
        void push_back(int a)
        {
            resizeAdd(m_size+1);
            m_nums[m_size]=a;
            m_size++;
        }
        
        //4
        void Print()
        {
            for (int i = 0; i < m_size; i++)
            {
                cout<<m_nums[i]<<" , ";
            }
            
        }
        
        //5
        void insert(int index ,int a) 
        {
            int p=0;
            if(m_size<m_capasity) 
            {
                p=m_capasity;
            }
            else
            {
                m_capasity=m_size*2;
                p=m_capasity;
            }
            int* NewArray=new int[p];
            for (int i = 0; i < m_size; i++)
            {
                if (i<index)
                {
                    NewArray[i]=m_nums[i];
                }
                else if(i==index)
                {
                    NewArray[i]=a;
                    NewArray[i+1]=m_nums[i];
                }
                else
                    NewArray[i+1]=m_nums[i];        
            }
            delete[]m_nums;
            m_nums=NewArray;
            m_size=m_size+1;
        }
        
        //6
        void erase(int index)
        {
            if(index<m_size)
            {
                int* NewArray=new int [m_capasity];
                for (int j = 0; j < m_size; j++)
                {
                    if (j<index)
                    NewArray[j]=m_nums[j];
                    else if (j>index)
                    NewArray[j-1]=m_nums[j];        
                }
                delete []m_nums;
                m_nums=NewArray;
                m_size=m_size-1;
            }
            else
            {
                m_nums=m_nums;
                m_size=m_size;
            }
        }
        
        void clear()
        {
            delete[]m_nums;
            m_size=0;
        }

    private:
        
    void resizeAdd(int NewSize)
    {
        if(NewSize>m_capasity)
        {
            int* NewArray= new int [m_size*2];
            for (int i = 0; i < m_size; i++)
            {
                NewArray[i] = m_nums[i];
            }
            delete[]m_nums;
            m_capasity=m_size*2;
            m_nums=NewArray;
        }
    };

};


int main()
{
    int nums[1]={1};
    MyVector m(1,nums);
    m.Print();
    cout<<"\n"; 
    m.push_back(14);
    m.Print();
    cout<<"\n"; 
    m.push_back(15);
    m.Print();
    cout<<"\n"; 
    m.push_back(16);
    m.push_back(17);
    m.push_back(18);
    m.Print();
    cout<<"\n"; 
    m.insert(0,5);
    m.insert(5,100);
    m.Print();
    cout<<"\n"; 
    m.erase(5); 
    m.Print();  
    m.clear();
    cout<<"\n";
    cout<<m.m_size;
    m.Print();
}