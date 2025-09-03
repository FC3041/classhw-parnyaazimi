//Part5
namespace Power;

class Program
{
    public static void Power(int a , int b)
    {
        int result=1;
        for (int i = 0; i < b; i++)
            result*=a;
        Console.WriteLine($"a ^ b = {result}");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your number base: ");
        var inputa=Console.ReadLine();
        Console.WriteLine("Please enter your number power: ");
        var inputb=Console.ReadLine();
        Power(Convert.ToInt32(inputa),Convert.ToInt32(inputb));
    }
}
