namespace Part2;
using System;
using NUnit.Framework;

class Program
{
    public static bool Is_divisible(int a,int b)
    {
        Assert.That(b!=0,"b can be oppposite to zero");
        if(a%b==0)
            return true;
        return false;
    }

    public static bool Is_prime(int n)
    {
        Assert.That(n>=2,"n can not be less than 2");
        if(n==2)
            return true;
        else
        {
            for (int i = 2; i < n; i++)
            {
                if(Is_divisible(n,i)==true)
                    return false;
            }
            return true;
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Is_prime(1));   
    }
}
