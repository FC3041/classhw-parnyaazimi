namespace Part3;
using System;
class Program
{
    //Part3
    public static double Exp2(int x,double precision)
    {
        int n=0;
        double count=1;
        double e=0;
        while (count>=precision)
        {
            e+=count;
            n++;
            count*=(double)x/n;
        }
        return e;
    }

    //A
    public static double Abs(double a)
    {
        if(a>=0)
            return a;
        return -a;
    }
    public static bool Near(double x,double y,double closeness = 0.001)
    {
        double diff=x-y;
        if(Abs(diff)<closeness)
            return true;
        return false;
    }

    //B
    public static int Power(int a , int b)
    {
        int result=1;
        for (int i = 0; i < b; i++)
            result*=a;
        return result;
    }
    public static long Factorial(int n)
    {
        long result=1;
        for (int i = 1; i <=n; i++)
            result*=i;
        return result;
    }
    public static double Exp(int x,double precision)
    {
        int n=0;
        double count=1;
        double e=0;
        while (count>precision)
        {
            e+=count;
            n++;
            count=(double)Power(x,n)/Factorial(n);
        }
        return e;
    }   

    
    static void Main(string[] args)
    {
        double out1=Exp(1,0.000001);
        double out2=Exp2(1,0.000001);
        Console.WriteLine(Near(out1,out2));

    }
}
