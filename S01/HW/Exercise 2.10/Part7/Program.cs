namespace Part7;
using System;
using NUnit.Framework;
class Program
{

    public static double Power(double a , int b)
    {
        double result=1;
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
    public static double Exp(double x,double precision)
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
    public static double Ln(double x,double precision)
    {
        Assert.That(x>0,"this is impossible");
        double lowerBound;
        double upperBound;

        if (x >= 1)
        {
            lowerBound = 0;
            upperBound = x;
        }
        else
        {
            lowerBound = x;
            upperBound = 0;
        }
        double mid = (lowerBound+upperBound)/2;
        while (Math.Abs(upperBound-lowerBound) > precision)
        {
            double exp_mid = Exp(mid,precision);
            if (exp_mid < x)
                lowerBound = mid;
            else
                upperBound = mid;
            mid = (lowerBound+upperBound)/2;
        }
        return mid;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Ln(10,0.00001));
    }
}
