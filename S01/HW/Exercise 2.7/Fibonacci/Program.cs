//Part5
namespace Fibonacci;
using System;
class Program
{
    public static int Fibonacci(int n)
    {
        int F1=1;
        int F2=1;
        int Fx=1;
        if (n==0)
            return 0;
        else if (n==1 || n==2)
            return 1;
        else
        {
            for (int i =0; i < n-2; i++)
            {
                Fx=F1+F2;
                F1=F2;
                F2=Fx;
            }
            return Fx;
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("n \t number");
        Console.WriteLine("----------------");
        for (int i = 0; i <= 20; i++)
        {
            Console.WriteLine($"{i} \t {Fibonacci(i)}");
        }
    }
}
