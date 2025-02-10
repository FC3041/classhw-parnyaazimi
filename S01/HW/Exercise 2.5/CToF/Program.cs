//Part2
namespace CToF;

class Program
{
    public static void Convert_temperature(double C)
    {
        double F=(C*9/5)+32;
        double C_round =Math.Round(C, 2);
        double F_round =Math.Round(F, 2);
        string output=Convert.ToString(C_round)+" : "+Convert.ToString(F_round);
        Console.WriteLine(output);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your number(degrees in Celsius ): ");
        var input=Console.ReadLine();
        double input1=Convert.ToDouble(input);
        Convert_temperature(input1);
    }
}
