//Part2 and Part3 and Part4

namespace MoreAsciiiArt;

class Program
{
    public static void Print_left_triangle(int n)
    {
        for(int i =1;i<=n;i++)
        {
            if(i%2==0)
            {
                for(int j=0;j<i;j++)
                    Console.Write('*');

                Console.Write("\n");
            }
            else
            {
                for(int t=0;t<i;t++)
                    Console.Write('%');

                Console.Write("\n");
            }
        }
    }

    public static void Print_cone(int baseSize)
    {
        int m=((baseSize-1)/2)+1;
        
        for (int i=0 ; i<m;i++)
            Console.Write(" ");

        Console.WriteLine('^');
        for (int j = 1; j <= m; j++)
        {
            for (int t = 0; t < m-j; t++)
                Console.Write(" ");

            for (int p = 0; p < j; p++)
                Console.Write('/');

            Console.Write('|');

            for (int r = 0; r < j; r++)
                Console.Write('\\');  
                
            Console.Write("\n");          
        }
    }
    static void Main(string[] args)
    {
        Print_left_triangle(10);
        Console.WriteLine("+-----------------+");
        Print_cone(7);
        Console.WriteLine("+-----------------+");
        for (int k = 1; k <= 9; k++)
        {
            if(k%2!=0)
                Print_cone(k);
        }
    }
}
