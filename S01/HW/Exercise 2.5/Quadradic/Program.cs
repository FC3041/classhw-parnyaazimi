//Part6
namespace Quadradic;

class Program
{
    public static double[] Quadradic(double A,double B,double C)
    {
        double delta=(B*B)-(4*A*C);
        if (delta<0)
            return new double[] { };
            
        else if (delta==0)
        {
            double X1=-B/(2*A);
            return new double[] {X1,X1};
        }
        else
        {
            double X1=((-B)+ Math.Sqrt(delta) )/(2*A);
            double X2=((-B) - Math.Sqrt(delta))/(2*A);
            return new double[] {X1,X2};
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your number1: ");
        var inputA=Console.ReadLine();

        Console.WriteLine("Please enter your number2: ");
        var inputB=Console.ReadLine();

        Console.WriteLine("Please enter your number3: ");
        var inputC=Console.ReadLine();

        double[] result=Quadradic(Convert.ToDouble(inputA),Convert.ToDouble(inputB),Convert.ToDouble(inputC));
        if(result.Length==0)
            Console.WriteLine("The equation has not real root");
        else
        {
            Console.WriteLine($"root one: {Convert.ToString(result[0])}");
            Console.WriteLine($"root two: {Convert.ToString(result[1])}");
        }
    }
}
