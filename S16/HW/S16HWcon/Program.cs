namespace S16HWcon;

class Program
{
    static void print_citizen(Citizen[] cs)
    {
        foreach(var c in cs)
            Console.WriteLine(c.ToString());
    }
    static void Main(string[] args)
    {
        Teacher t1=new Teacher("Pari","Saberi",1,false,500,10,1);
        System.Console.WriteLine(t1);
    }
}
