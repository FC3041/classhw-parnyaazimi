public interface IVehicles
{
    public int capacity();
    public double Area();
    public int Wheels();
    public double MaxSpeed();

}

public class Bicycle:IVehicles
{
    public double L;
    public double W;
    public double MaxSpeedBicycle;
    public Bicycle(double LL, double WW,double MS)
    {
        L=LL;
        W=WW;
        MaxSpeedBicycle=MS;
    }

    public double Area()
    {
        return L*W;
    }

    public int capacity()
    {
        return 3;
    }

    public double MaxSpeed()
    {
        return MaxSpeedBicycle;
    }

    public int Wheels()
    {
        return 2;
    }
}

public class Tractor:IVehicles
{
    public double L;
    public double W;
    public double MaxSpeedTractor;
    public Tractor(double LL, double WW,double MS)
    {
        L=LL;
        W=WW;
        MaxSpeedTractor=MS;
    }

    public double Area()
    {
        return L*W;
    }

    public int capacity()
    {
        return 5;
    }

    public double MaxSpeed()
    {
        return MaxSpeedTractor;
    }

    public int Wheels()
    {
        return 4;
    }
}

public class Trolly:IVehicles
{
    public double L;
    public double W;
    public double MaxSpeedTrolly;
    public Trolly(double LL, double WW,double MS)
    {
        L=LL;
        W=WW;
        MaxSpeedTrolly=MS;
    }

    public double Area()
    {
        return L*W;
    }

    public int capacity()
    {
        return 10;
    }

    public double MaxSpeed()
    {
        return MaxSpeedTrolly;
    }

    public int Wheels()
    {
        return 18;
    }
}
