#include<iostream>
using namespace std;

int StrLen(string enterstr)
{
    int count=0;
    int i=0;
    while (enterstr[i]!=0)
    {
        count++;
        i++;
    }
    return count;    
}
class MyString
{
    public:

        char* m_nums;

        MyString(string enterNums)
        {
            m_nums=new char[StrLen(enterNums)+1];
            int i=0;
            for (i = 0; i < StrLen(enterNums); i++)
                m_nums[i]=enterNums[i];   
            m_nums[i]='\0';
        }

        MyString(){}

        ~MyString()
        {
            delete[] m_nums;
        }

        int size()const
        {
            int count=0;
            int i=0;
            while (m_nums[i]!=0)
            {
                count++;
                i++;
            }
            return count;  
        }
        
        void Assign(string str2)
        {
            m_nums=new char[StrLen(str2)+1];
            for (int i = 0; i < StrLen(str2); i++)
            {
                m_nums[i]=str2[i];
            }
            m_nums[StrLen(str2)]='\0';
       }

        void AddLine()const
        {
            cout<<"\n";
        }

        void appandCharacter(char c)
        {
            char* newString=new char[size()+2];
            for ( int i = 0; i < size() && m_nums[i]!=0; i++)
            {
                newString[i]=m_nums[i];
            }
            newString[size()]=c;
            newString[size()+1]='\0';
            delete[]m_nums;
            m_nums=newString;
             
        }

        void appandString(MyString str2)
        {
            int newSize=size() + str2.size();
            char* str3=new char[newSize+1];
            for (int i = 0; i < size() && m_nums[i]!=0; i++)
            {
                str3[i]=m_nums[i];
            }
            int j=0;
            for (j = 0; j < str2.size() && str2.m_nums[j]!=0; j++)
            {
                str3[j+size()]=str2.m_nums[j];
            }
            str3[j+size()]='\0';
            delete[] m_nums;
            m_nums= str3;
        }

        string c_str()const
        {   
            return (string)m_nums;
        }

        void Print()
        {
            for (int i = 0; i < size(); i++)
            {
                cout<<m_nums[i];
            }
            
        }
};


int main()
{
    MyString S;
    S.Assign("Parnya");
    cout<<S.c_str();
    S.AddLine();
    S.appandCharacter('+');
    MyString name2("Jeyran");
    S.appandString(name2);
    cout<<S.c_str();
    S.AddLine();
    cout<<"======\n";
    S.Print();
}