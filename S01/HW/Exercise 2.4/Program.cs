namespace Exercise_2._4;

class Program
{
    //Part1

    public static void Print_n_times(int n,char STR)
    {
        for (int i = 0; i < n; i++)
            Console.Write(STR);
        
        Console.Write("\n");

    }
    public static void Print_left_triangle1(int n)
    {
        for (int i = 1; i <= n; i++)
            Print_n_times(i,'*');

    }

    //Part2
    public static void Print_left_triangle2(int n,char character)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < i; j++)
                Console.Write(character);
            
            Console.Write("\n");
        }
    }

    //Part3
    static void Print_right_triangle(int n,char character)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < n-i; j++)
                Console.Write(" ");
            
            for (int t = 0; t < i; t++)
                Console.Write(character);
            
            Console.Write("\n");
        }
    }
    static void Main(string[] args)
    {
        Print_left_triangle1(20);
        Print_left_triangle2(20,'*');
        Print_left_triangle2(20,'%');
        Print_right_triangle(20,'*');
    }
}
