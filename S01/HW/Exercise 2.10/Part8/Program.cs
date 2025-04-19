namespace Part8;
using System;

class Program
{

    public static List<double> Min_Max_Sum(List<double> numbers)
    {
        double sum = 0;
        double min = numbers[0];
        double max = numbers[0];
        for (int i = 0; i < numbers.Count; i++)
        {
            if(numbers[i]<min)
                min =numbers[i];
            if(numbers[i]>max)
                max =numbers[i];
            sum+=numbers[i];            
        }
        List<double> outList=new List<double>();
        outList.Add(sum);
        outList.Add(min);
        outList.Add(max);
        return outList;
    }
    static void Main(string[] args)
    {

        List<double> numbers=new List<double>();
        while (true)
        {
            Console.WriteLine("enter a number: ");
            double input = Convert.ToInt32(Console.ReadLine());
            if (input == -1)
                break;

            numbers.Add(input);
        }
        List<double> outnumber=new List<double>();
        outnumber=Min_Max_Sum(numbers);
        Console.WriteLine($"sum: {outnumber[0]}");
        Console.WriteLine($"min: {outnumber[1]}");
        Console.WriteLine($"max: {outnumber[2]}");
    }
}
