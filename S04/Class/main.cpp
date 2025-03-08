#include<iostream>
using namespace std;


class Date
{
    int day;
    int month;
    int year;

};

class Person 
{
    public:
        int m_NID;
        char m_fname[20];
        char m_lname[20];   
        Date m_BD;

        Person(const char* fname,const char* lname,int NID,Date BD)
        :m_BD(BD),m_NID(NID)
        {
            int i=0;
            // for ( i = 0; i < sizeof(m_fname) && fname[i]!='\0'; i++)
            // {
            //     m_fname[i]=fname[i];
            // }
            *m_fname=*fname;
            m_fname[i]='\0';

            int j=0;
            for ( j = 0; j < sizeof(m_lname) && lname[j]!='\0'; j++)
            {
                m_lname[j]=lname[j];
            }
            m_lname[j]='\0';

        };

        void print_person()
        {
            cout << "First name : "<<m_fname<<endl;
            cout << "LAst name : "<<m_lname<<endl;            
        }
};

int main()
{
    Date d;
    Person p1("Ali","Hosseini",12345,d);
    p1.print_person();
}