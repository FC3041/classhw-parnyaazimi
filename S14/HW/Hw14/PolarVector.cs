using System.Numerics;
public interface IPolarVector
{
    double R {get;set;}
    double O {get;set;}

    PolarVector Add(PolarVector PV);
    MyVector<double> CartesianVector();

}
public class PolarVector : IPolarVector, IEquatable<PolarVector>, IComparable<PolarVector>
{
    public double R { get; set; }
    public double O { get; set; }

    public PolarVector(double R,double O)
    {
        this.R=R;
        this.O=O;
    }
    public MyVector<double> CartesianVector()
    {
    {
        double X=R*Math.Cos(O);
        double Y=R*Math.Sin(O);
        return new MyVector<double>(X,Y);
    }
    }
    public PolarVector Add(PolarVector PV)
    {
        var V1=this.CartesianVector() ;
        var V2=PV.CartesianVector();
        double NewX=V1.X+V2.X;
        double NewY=V1.Y+V2.Y;
        double NewR=Math.Sqrt(NewX*NewX + NewY*NewY);
        double NewO = Math.Atan2(NewY, NewX);
        return new PolarVector(NewR,NewO);

    }

    
    public bool Equals(PolarVector other)
    {
        if (null == other)
            return false; 
        return (this.R==other.R) && (this.O==other.O);
    }

    public override bool Equals(object other)
    {
        PolarVector obj=other as PolarVector;
        if (null == other)
            return false; 
        return Equals(obj);
    }
    public int CompareToR(PolarVector other)=>this.R.CompareTo(other.R);
    public int CompareToO(PolarVector other)=>this.O.CompareTo(other.O);
    public int CompareTo(PolarVector other)
    {
        if (this.CompareToR(other)==1 &&this.CompareToO(other)==1)
            return 1;
        return 0;
    }
}