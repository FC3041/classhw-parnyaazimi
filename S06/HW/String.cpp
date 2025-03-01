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
class MyStr
{
    public:
        int m_size;
        char* m_PChars;

        MyStr():m_size(0),m_PChars(nullptr){};

        MyStr(const char* chars)
        {
            int i;
            for(i=0;chars[i]!='\0';i++);
            m_size = i+1;

            m_PChars = (char*)malloc(sizeof(char)*(m_size));
            for(i=0; i<m_size;i++)
            {
                m_PChars[i] = chars[i];
            }
            m_PChars[m_size] = '\0';
        }

        MyStr(const char* chars, int start, int count)
        :m_size(count)
        {
            m_PChars = (char*)malloc(sizeof(char)*(m_size+1));

            for(int i=0;i<m_size ;i++)
            {
                m_PChars[i] = chars[start+i];
            }
            m_PChars[count] = '\0';

        }

        void Assign(string str2)
        {
            m_PChars=new char[StrLen(str2)+1];
            for (int i = 0; i < StrLen(str2); i++)
            {
                m_PChars[i]=str2[i];
            }
            m_PChars[StrLen(str2)]='\0';
       }


        int len()const
        {
            int count=0;
            int i=0;
            while (m_PChars[i]!=0)
            {
                count++;
                i++;
            }
            return count;  
        }

        void add(MyStr str2)
        {
            int newSize=len() + str2.len();
            char* str3=new char[newSize+1];
            for (int i = 0; i < len() && m_PChars[i]!=0; i++)
            {
                str3[i]=m_PChars[i];
            }
            int j=0;
            for (j = 0; j < str2.len() && str2.m_PChars[j]!=0; j++)
            {
                str3[j+len()]=str2.m_PChars[j];
            }
            str3[j+len()]='\0';
            delete[] m_PChars;
            m_PChars= str3;
        }

        bool checkSubstr(string str)
        {
            for (int i = 0; i < len() - StrLen(str); i++)
            {
                bool flag=true;
                int j=0;
                while (j<StrLen(str))
                {
                    if (m_PChars[j+i]!=str[j])
                    {
                        flag = false;
                        break;
                    } 
                    j++;                   
                }   
                if (flag==true)
                {
                    return true;
                }

            }  
            return false;          
        }
        void printStr()
        {
            cout << m_PChars << endl;
        }
};


int main()
{
    MyStr s1;

    MyStr s2("malihe hajihosseini", 7, 12);
    s2.printStr();
    cout<<s2.checkSubstr("hadi"); // TODO1
    cout<<endl;
    cout<<s2.len(); //TODO2
    cout<<endl;
    s1.Assign(" teacher");
    s2.add(s1); // TODO3 
    s2.printStr();  
}