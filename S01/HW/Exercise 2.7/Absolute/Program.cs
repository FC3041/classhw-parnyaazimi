//Part1
namespace Absolute;
using System;

class Program
{
    public static double Absolute_value(double x)
    {
        if(x>=0)
            return x;
        return -x;
    }
    static void Main(string[] args)
    {
        Console.WriteLine (Absolute_value(-100));
        Console.WriteLine (Absolute_value(0));
        Console.WriteLine (Absolute_value(-1));
        Console.WriteLine (Absolute_value(1));
        Console.WriteLine (Absolute_value(1000));
    }
}
