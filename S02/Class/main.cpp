#include<iostream>
#include <math.h>
using namespace std;

class Point
{   
    public:
        double x;
        double y;

        Point(double t, double r)
        {
            x=t;
            y=r;
            cout << " x in c:" <<x<< ",y in c :"<<y<<endl;
        }

        Point(double w)
        {
            x=w;
            y=w;
        }

        // Point(Point* p)
        // {
        //     x=p->x;
        //     y=p->y;
        // }
        // Point(const Point& p)
        // {
        //     x=p.x;
        //     y=p.y;
        // }

        Point(Point& p) //const correnctness
        {
            x=p.x;
            p.y+=1;
            y=p.y;
        }

        void print_point()
        {
            cout<<"x: " <<x<<",y: " <<y<<endl;
        
        };
        double Print_d(Point p2)
        {
            double dx=x - p2.x;
            double dy=y - p2.y;
            return sqrt(dx*dx + dy*dy);
        };

        ~Point()
        {
            cout << " x in d:" <<x<< ",y in d :"<<y<<endl;
        }
};

// void print_point(Point p)
// {
//     cout<<"x: " <<p.x<<",y: " <<p.y<<endl;

// };


// double Print_d(Point p1 , Point p2)
// {
//     double dx=p1.x - p2.x;
//     double dy=p1.y - p2.y;
//     return sqrt(dx*dx + dy*dy);
// };



int main()
{
    
    // int a;
    // cin>>a;
    // cout<<"a:"<<a<<endl;

    // Point p1;
    // p1.x=4;
    // p1.y=5;

    // Point p2;
    // p2.x=-5;
    // p2.y=10;

    // cout<< p1.x << endl;

    // print_point(p1);
    // print_point(p2);
    // double r=Print_d(p1,p2);
    // cout<<r<<endl;

    // p1.print_point();
    // p2.print_point();

    // cout<<p1.Print_d(p2)<<endl;

    // Point p1(2,5);
    // Point p2(4);

    Point p1(1,1);
    int c=5;
    if(c>3)
        Point p2(2,2);
    else
        Point p3(3,3);

}