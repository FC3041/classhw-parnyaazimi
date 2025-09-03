namespace Part6;
using System;
using NUnit.Framework;
class Program
{
    public static double Power(double a , double b)
    {
        double result=1;
        for (int i = 0; i < b; i++)
            result*=a;
        return result;
    } 
    public static double Root(int x , int n , double precision)
    {
        Assert.That((x<0 && n%2!=0)|| (x>0), Is.True);
        double lowerBound;
        double upperBound;
        if (x < 1)
        {
            lowerBound = x;
            upperBound = 1;
        }
        else
        {
            lowerBound = 0;
            upperBound = x;
        }
        double mid=(lowerBound+upperBound)/2;
        while (Math.Abs(upperBound-lowerBound)>precision)
        {
            double mid_power=Power(mid,n);
            if (mid_power < x)
                lowerBound = mid;
            else
                upperBound = mid;
            mid=(lowerBound+upperBound)/2;
        }
        return mid;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(Root(16,4,0.00001));
    }
}
