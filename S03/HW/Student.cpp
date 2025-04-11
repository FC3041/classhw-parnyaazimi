#include<iostream>
#include<string.h>
#include<stdlib.h>

class Student
{
    public:
        int* m_stdNum;
        char* m_FirstName;
        char* m_LastName;
        int m_CoursesPassed=0;
        int m_Credits[40];
        char* m_CourseNames[40];
        double m_Grades[40];

        Student(){}

        Student(int* stdnum, const char* fname, const char* lname)
        {
            m_stdNum = new int;
            *m_stdNum=*stdnum;
            m_FirstName=new char[strlen(fname)+1];
            strcpy(m_FirstName,fname);
            m_LastName=new char[strlen(lname)+1];
            strcpy(m_LastName,lname);
        }
        ~Student()
        {
            delete m_stdNum;
            delete[] m_FirstName;
            delete[] m_LastName;

            for (int i = 0; i < m_CoursesPassed; i++) 
                delete[] m_CourseNames[i];
        }

        double GetGPA()
        {
            double sumGrade = 0;
            int sumCredit = 0;
            for(int i=0; i<m_CoursesPassed; i++) 
            {
                sumGrade += m_Credits[i] * m_Grades[i];
                sumCredit += m_Credits[i];
            }
            return sumGrade / sumCredit;
        }

        
        void register_course(int credits, const char* name, double grade)
        {
            m_Credits[m_CoursesPassed] = credits;
            m_Grades[m_CoursesPassed] = grade;
            char* namecopy = new char[strlen(name) + 1];
            strcpy(namecopy, name);
            m_CourseNames[m_CoursesPassed] = namecopy;
            m_CoursesPassed++;
        }

        void list_courses()
        {
            for(int i=0; i<m_CoursesPassed; i++) 
            {
                std::cout << m_CourseNames[i] << ": "
                          << m_Credits[i] << " : "
                          << m_Grades[i] << std::endl;        
            }
        }
    };

    int main()
    {
        int stdnum;
        char firstname[20];
        char lastname[20];

        std::cout<<"enter your student number ?"<<std::endl;
        std::cin>>stdnum;
        std::cout<<"enter your first name ?"<<std::endl;
        std::cin>>firstname;
        std::cout<<"enter your last name ?"<<std::endl;
        std::cin>>lastname;
        std::cout<<"\n "<<std::endl;

        Student s(&stdnum,firstname,lastname);
        int i=0;
        int j=0;
        std::cout<<"Student number: "<<*s.m_stdNum<<" , "<<std::endl;
        std::cout<<"First name: "<<std::ends;
                while (s.m_FirstName[i]!=0)
                {
                    std::cout<<s.m_FirstName[i]<<std::ends;
                    i++;
                }
        std::cout<<" , "<<std::endl;
        std::cout<<"Last name: "<<std::ends;
                while (s.m_LastName[j]!=0)
                {
                    std::cout<<s.m_LastName[j]<<std::ends;
                    j++;
                }
                std::cout<<"\n "<<std::endl;

        char bufc[20];
        double grade;
        int credits;
        while(true)
        {
            std::cout << "course name?" ;
            std::cin >> bufc ;
            if (*bufc == 'A')
                break;
            std::cout << "course credits?" ;
            std::cin >> credits ;
            std::cout << "course grade?" ;
            std::cin >> grade ;
            s.register_course(credits, bufc, grade);
        }
        s.list_courses();
        std::cout<<"======"<<std::endl;
        std::cout << "GPA: "<< s.GetGPA() << std::endl;
        return 0;

}

