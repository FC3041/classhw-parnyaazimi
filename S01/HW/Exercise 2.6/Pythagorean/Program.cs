//Part7
namespace Pythagorean;

class Program
{
    public static void Fisaghorec(int n)
    {
        for (int a = 2; a < n; a++)
        {
            for (int b = a+1; b < n; b++)
            {
                int c = (int)Math.Sqrt(a*a + b*b);
                if (c*c == a*a + b*b && c < n)
                    Console.WriteLine($"{a}, {b}, {c}");

            }
        }
    }
    static void Main(string[] args)
    {
        Fisaghorec(100);
    }
}
