//Part2
namespace Part2;
using System;
class Program
{
    public static long Factorial(int n)
    {
        long result=1;
        for (int i = 1; i <=n; i++)
            result*=i;
        return result;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("+-------------------------+");
        for (int i = 1; i < 21; i++)
        {
            Console.WriteLine($"{i} : {Factorial(i)}");
        }
        Console.WriteLine("+-------------------------+");
    }

}
