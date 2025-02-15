#include <iostream>
#include <math.h>
using namespace std;

class Point
{
    public:
        double x;
        double y;
        Point(double w, double t)
        {
            x=w;
            y=t;
        }
        // ~Point()
        // {
        //     cout<<"x in d: "<<x <<", y in d : "<<y<<endl;
        // };
};

class Circle
{
    public:
        double cx;
        double cy;
        double r;

        Circle(double w,double t,double m)
        {
            cx=w;
            cy=t;
            r=m;
        }

        Circle(double n,double q)
        {
            cx=n;
            cy=n;
            r=q;
        }        
        
        double Perimeter()
        {
            double P=2*r*M_PI;
            return P;
        }

        double Area()
        {
            double A=M_PI*r*r;
            return A;
        }

        double Distance_C(const Circle& Circle2)
        {
            double d_x=cx - Circle2.cx;
            double d_y=cy - Circle2.cy;
            double distance=sqrt(d_x*d_x + d_y*d_y);
            return distance;
        }

        double Distance_P(const Point& p)
        {
            double d_x=cx - p.x;
            double d_y=cy - p.y;
            double distance=sqrt(d_x*d_x + d_y*d_y);
            return distance;            
        }

        bool InCircle(const Point& p)
        {
            if(Distance_P(p)<r)
                return true;
            return false;
        }
        // ~Circle()
        // {
        //     cout<<"cx in d: "<<cx <<", cy in d : "<<cy<<", r in d : "<<r<<endl;   
        // };

};

int main()
{
    Circle Circle1(4,9,2);
    Circle Circle2(8,5);
    Point Pt (4,6);

    //Circle1
    cout<< "Perimeter_Circle1 : "<<Circle1.Perimeter()<<endl;
    cout<< "Area_Circle1 : "<<Circle1.Area()<<endl;
    cout<< "Distance_Circle1_Point : "<<Circle1.Distance_P(Pt)<<endl;
    cout<< "Point in Circle1 : "<<Circle1.InCircle(Pt)<<endl<<endl; 
    
    //Circle2
    cout<< "Perimeter_Circle2 : "<<Circle2.Perimeter()<<endl;
    cout<< "Area_Circle2 : "<<Circle2.Area()<<endl;
    cout<< "Distance_Circle2_Point : "<<Circle2.Distance_P(Pt)<<endl;
    cout<< "Point in Circle2 : "<<Circle2.InCircle(Pt)<<endl<<endl; 
    
    //Distance
    cout<< "Distance_C : "<<Circle1.Distance_C(Circle2)<<endl<<endl;
}