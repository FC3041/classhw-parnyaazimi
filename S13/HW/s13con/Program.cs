using HW;

namespace s13con;

class Program
{
    public static void PrintPersons(IPerson<int>[] ps)
    {
        foreach(var p in ps)
            Console.WriteLine(p);
    }    
    public static void Main(string[] args)
    {
        Student [] students ={ 
            new Student() {
                FirstName="Nali",
                LastName="Hamedi",
                GPA = 18.5,
                Id = 12
            },
            new Student() {
                FirstName="Mali",
                LastName="Zamedi",
                GPA = 16.5,
                Id = 5
            },
            new Student() {
                FirstName="Zali",
                LastName="Amedi",
                GPA = 19.5,
                Id = 1
            },
        };

        System.Console.WriteLine("PersonComparers");
        PrintPersons(students);

        MySort(students, PersonComparers.PFC);
        System.Console.WriteLine("----------------");
        PrintPersons(students);

        MySort(students, PersonComparers.PLC);
        System.Console.WriteLine("----------------");
        PrintPersons(students);

        MySort(students,PersonComparers.PIC);
        System.Console.WriteLine("----------------");
        PrintPersons(students);
        
        MySort(students,PersonComparers.PFuulNC);
        System.Console.WriteLine("----------------");
        PrintPersons(students);
        System.Console.WriteLine("----------------");


        //StingComparer
        System.Console.WriteLine("StingComparer");
        Word string1=new();
        string1.word="Parnya";
        string1.WordLength=6;
        Word string2=new();
        string2.word="parnya";
        string2.WordLength=6;

        Console.WriteLine($"MyStringComparer.ordina: {MyStringComparer.ordina.Compare(string1,string2)}");
        System.Console.WriteLine("----------------");
        Console.WriteLine($"MyStringComparer.ordinalIgnoreCase: {MyStringComparer.ordinalIgnoreCase.Compare(string1,string2)}");

    }

    private static void MySort(IPerson<int>[] persons, IComparer<IPerson<int>> cmp)
    {
        for(int i=0; i<persons.Length; i++)
            for(int j=i+1; j<persons.Length;j++)
                if (cmp.Compare(persons[i], persons[j]) > 0)
                    swap<IPerson<int>>(persons, i, j);
    }

    private static void swap<T>(T[] items, int i, int j)
    {
        T tmp = items[i];
        items[i] = items[j];
        items[j] = tmp;
    }

    #region Hide
    static void Main2(string[] args)
    {
        try
        {
            int x = 0;
            int w = 5 / x;

            // code after potential error
        }
        catch(FormatException e)
        {
            // code error handling
            Console.WriteLine(e.Message);
            throw;
        }
        catch(NullReferenceException nfe)
        {

        }
        finally
        {

        }
    }
    #endregion
}
