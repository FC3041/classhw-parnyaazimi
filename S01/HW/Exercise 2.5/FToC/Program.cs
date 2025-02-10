//Part1
namespace FToC;

class Program
{
    public static void Convert_temperature(double F)
    {
        double C=(F - 32) * 5/9;
        double C_round =Math.Round(C, 2);
        double F_round =Math.Round(F, 2);
        string output=Convert.ToString(F_round)+" : "+Convert.ToString(C_round);
        Console.WriteLine(output);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your number(degrees Fahrenhei): ");
        var input=Console.ReadLine();
        double input1=Convert.ToDouble(input);
        Convert_temperature(input1);
    }
}
