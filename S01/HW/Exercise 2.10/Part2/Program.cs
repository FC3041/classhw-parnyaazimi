namespace Part2;
using System;
class Program
{

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
        Console.WriteLine(Exp(1,0.0000001));
    }
}
