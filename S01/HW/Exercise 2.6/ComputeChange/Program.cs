//Part6
namespace ComputeChange;

class Program
{
    public static void Compute_change(int money)
    {
        int moneyout=100-money;

        int quarters=moneyout/25;
        moneyout-=(25*quarters);

        int nickels=money/5;
        moneyout-=(5*nickels);

        int dimes=moneyout/10;
        moneyout-=(10*dimes);
        
        int pennies=moneyout;

        Console.WriteLine($"quarters= {quarters}");
        Console.WriteLine($"nickels= {nickels}");
        Console.WriteLine($"dimes= {dimes}");
        Console.WriteLine($"pennies= {pennies}");
    }
    static void Main(string[] args)
    {
        Compute_change(8);
    }
}
