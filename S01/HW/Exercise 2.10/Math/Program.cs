namespace Math;
using System;
class Program
{
    //Part1
    public static long Factorial(int n)
    {
        long result=1;
        for (int i = 1; i <=n; i++)
            result*=i;
        return result;
    }
    public static double Eulers_constant(double precision)
    {
        int n=0;
        double e=0;
        double factorial = 1;
        while (factorial >= precision)
        {
            e += factorial;
            n++;
            factorial = 1.0 / Factorial(n);
        }
        return e;
    }

    //Part4

    public static double Sin(double x, double precision)
    {
        int n = 1;
        x *= Math.PI / 180;
        double jomle_donbale = x;
        double result = jomle_donbale;

        while (Math.Abs(jomle_donbale) > precision)
        {
            jomle_donbale = Math.Pow(-1, n) * Math.Pow(x, (2*n)+1)/Factorial((2*n)+1);
            result += jomle_donbale;
            n++;
        }
        return result;
    }


    static void Main(string[] args)
    {
        Console.WriteLine($"Part1 : Eulers_constant(0.0001) = {Eulers_constant(0.0001)}");
        Console.WriteLine($"Part4 : Sin(90,0.001) = {Sin(90,0.001)}");
        Console.WriteLine($"Part4 : Sin(45,0.001) = {Sin(45,0.001)}");
    }
}
