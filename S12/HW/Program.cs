namespace HW;

class Program
{
    static void Main(string[] args)
    {
        List<IVehicles> vehicles=new()
        {
            new Bicycle(12,5,15),
            new Tractor(30,20,55),
            new Trolly(80,40,80)
        };

        double Area_sum = 0;
        double Capacity_sum = 0;

        for(int i=0; i<vehicles.Count;i++)
        {
            Capacity_sum += vehicles[i].capacity();
            Area_sum += vehicles[i].Area();
        }

        Console.WriteLine(Area_sum);
        Console.WriteLine(Capacity_sum);
    }
}
