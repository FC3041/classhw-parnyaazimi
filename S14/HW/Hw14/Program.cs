namespace Hw14;

class Program
{
    static void Main(string[] args)
    {
        PolarVector P1=new PolarVector(5,57);
        PolarVector P2=new PolarVector(2,104);

        MyVector<double> P3=P1.CartesianVector();
        Console.WriteLine($"{P3.X},{P3.Y}");
    }
}
