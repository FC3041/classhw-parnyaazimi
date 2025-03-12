namespace Part5;
using System;
class Program
{
    public static double Square_root(double x, double precision)
    {
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
            if (Math.Pow(mid,2)<x)
                lowerBound = mid;
            else    
                upperBound = mid; 
            mid=(lowerBound+upperBound)/2;
        }
        return mid;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Square_root(0.5, 0.000001));
    }
}
