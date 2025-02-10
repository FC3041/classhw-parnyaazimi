//Part5
namespace Calendar;

class Program
{
    public static void Print_month(string[] month)
    {
        for (int i = 1; i <= 12; i++)
            Console.WriteLine($"{i}\t{month[i-1]}");
    }
    static void Main(string[] args)
    {
        string[] Month={"January","February","March","April","May","June","July","August","September","October","November","December"};
        Print_month(Month);
    }
}
