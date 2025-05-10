using System.Numerics;

public interface IVector<T> where T: INumber<T>
{
    T Magnitude {get;}
    MyVector<T> Add(IVector<T> o);
    T X {get; set;}
    T Y {get; set;}
}
public class MyVector<T>: 
    IEquatable<MyVector<T>>, 
    IComparable<MyVector<T>>,
    IVector<T>
        where T: INumber<T>
{
    public T X {get; set;}
    public T Y {get; set;}
    public T Magnitude => X*X + Y*Y;

    public MyVector(T x, T y)
    {
        this.X = x;
        this.Y = y;
    }

    public MyVector<T> Add(IVector<T> v) => new MyVector<T>(X + v.X, Y + v.Y);
    
    bool IEquatable<MyVector<T>>.Equals(MyVector<T> v)
    {
        if (null == v)
            return false;        
        return (v.X == this.X) && (v.Y == this.Y);
    }

    int IComparable<MyVector<T>>.CompareTo(MyVector<T> v) =>this.Magnitude.CompareTo(v.Magnitude);
    public override bool Equals(object obj)
    {        
        MyVector<T> v = obj as MyVector<T>;
        if (v != null)
            return Equals(v);
        return false;
    }

    public override int GetHashCode()
    {
        return this.X.GetHashCode() ^ this.Y.GetHashCode();
    }
}