namespace Exercise_2._2;

class Program
{
    public static void Head(int n)
    {
        int m=(n-2)/2 +1;
        for (int i = 0; i <= m; i++)
            Console.Write(" ");
        
        Console.Write('^');
        Console.Write("\n");
        for (int j = 1; j <=m; j++)
        {
            for (int k = 0; k <=m-j; k++)        
                Console.Write(" ");

            for (int t = 0; t <j; t++)
                Console.Write('/');
            
            Console.Write('|');
            for (int p = 0; p < j; p++)
                Console.Write('\\');
            
            Console.Write("\n");
        }
    }


    public static void Line(int n)
    {
        Console.Write('+');
        for (int i = 0; i < n; i++)
            Console.Write('-');
        
        Console.WriteLine('+');
    }

    public static void Body(int n,int w)
    {
        for (int i = 0; i < w; i++)
        {
            Console.Write('+');
            for (int j = 0; j < n; j++)
               Console.Write('*'); 
            
            Console.WriteLine('+');
        }
    }

    static void Main(string[] args)
    {
        Head(7);
        Line(7);
        Body(7,4);
        Line(7);
        Body(7,4);
        Line(7);
        Head(7);

    }
}
