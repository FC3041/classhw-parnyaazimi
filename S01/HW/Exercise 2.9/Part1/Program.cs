namespace Part1;
using System;
using NUnit.Framework;
class Program
{
    public static long Factorial(int n)
    {
        Assert.That(n>=0,"n can be positive");
            long result=1;
            for (int i = 1; i <=n; i++)
                result*=i;
            return result;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Factorial(5));
    }
}
