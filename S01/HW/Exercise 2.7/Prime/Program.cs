namespace Prime;
using System;
class Program
{
    //Part3
    public static bool Is_divisible(int a,int b)
    {
        if (a%b==0)
            return true;
        return false ;
    }
    //Part4
    public static bool Is_prime(int n)
    {
        if (n==0 || n==1)
            return false;
        else if(n==2)
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
        Console.WriteLine("  number");
        Console.WriteLine("-----------");
        for (int i = 0; i < 100; i++)
        {
            if(Is_prime(i))
                Console.WriteLine(i);
        }
    }
}
