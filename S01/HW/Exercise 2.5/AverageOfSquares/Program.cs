//Part7 and Part8
namespace AverageOfSquares;
class Program
{
    public static int Power(int a , int b)
    {
        int result=1;
        for (int i = 0; i < b; i++)
            result*=a;
        return result;
    }
    public static double Average_of_squares0(int n)
    {
        int sum=0;
        for (int i = 0; i < n; i++)
            sum+=Power(i,2);
        double result=(double)sum/n;
        return result;
    }
    public static double Average_of_squares1(int n)
    {
        double sum=0;
        for (int i = 1; i <= n; i++)
            sum+=Power(i,2);
        double result=(double)sum/n;
        return result;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your number0 : ");
        var input=Console.ReadLine();
        Console.WriteLine(Average_of_squares0(Convert.ToInt32(input)));

        Console.WriteLine("Please enter your number1 : ");
        var input1=Console.ReadLine();
        Console.WriteLine(Average_of_squares1(Convert.ToInt32(input1)));
    }
}
