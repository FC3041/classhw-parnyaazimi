#include<iostream>
#include<Windows.h>
using namespace std;
class KeepTime
{
    public:
        unsigned long long Tick1=0;
        KeepTime(string str)
        {
            cout<< str << " = ";
            Tick1=GetTickCount64();
            cout<<Tick1<<endl;
        }
        ~KeepTime()
        {
            unsigned long long Tick2=GetTickCount64();
            cout<< Tick2-Tick1 <<endl;
        }
};
int main()
{
    {
        KeepTime t("for loop 365 double mul");
        double d = 1;
        for(int i=0; i<365; i++)
        {
            for(int j=0 ; j<365; j++)
                d *=1.01;
        }
    }
    return 0;
}