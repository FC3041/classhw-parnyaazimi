//Part1
namespace LeapYear;
class Program
{
    public static bool Is_leap_year(int year)
    {
        if ((year % 400 == 0) || (year%4==0 && year%100!=0))
            return true;
        return false;
    }
    static void Main(string[] args)
    {
        Console.WriteLine($"1792\t{Is_leap_year(1792)}");
        Console.WriteLine($"1796\t{Is_leap_year(1796)}");
        Console.WriteLine($"1800\t{Is_leap_year(1800)}");
        Console.WriteLine($"1804\t{Is_leap_year(1804)}");
        Console.WriteLine($"1900\t{Is_leap_year(1900)}");
        Console.WriteLine($"1904\t{Is_leap_year(1904)}");
        Console.WriteLine($"2000\t{Is_leap_year(2000)}");
        Console.WriteLine($"2004\t{Is_leap_year(2004)}");
    }
}
