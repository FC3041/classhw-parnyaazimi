//Part3 and Part4
namespace Factorial;

class Program
{
    public static void Factorial(int n)
    {
        long result=1;
        for (int i = 1; i <=n; i++)
            result*=i;
        Console.WriteLine(result);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your number: ");
        var input=Console.ReadLine();
        int input1=Convert.ToInt32(input);
        Factorial(input1);
        Console.WriteLine("+-------------------------+");
        for (int i = 1; i < 21; i++)
        {
            Console.Write(i);
            Console.Write(" : ");
            Factorial(i);
        }
        Console.WriteLine("+-------------------------+");
    }
}
