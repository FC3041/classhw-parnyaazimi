using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading;
using System.Threading.Tasks;

namespace E3;



//Question0
public class Animal
{
    public virtual string MakeSound() => "Some generic animal sound";
}

public class Dog : Animal
{
    public override string MakeSound() => "Woof";
}



//Question1
public struct MyPointType2
{
    public int X { get; set; }
    public int Y { get; set; }
}

public class MyPointType1
{
    public int X { get; set; }
    public int Y { get; set; }
}



//Question2
public class Comparer<T> where T : IComparable
{
    public T Item1 { get; set; }
    public T Item2 { get; set; }

    public Comparer(T _item1, T _item2)
    {
        Item1 = _item1;
        Item2 = _item2;
    }

    public T GetLarger()
    {
        T Myout;
        if (Item1.CompareTo(Item2) > 0)
            Myout = Item1;
        else Myout = Item2;
        return Myout;
    }

}


public class Product : IComparable
{
    public string Name { get; set; }
    public int Price { get; set; }

    public int CompareTo(object obj)
    {
        Product product = obj as Product;
        return Price.CompareTo(product.Price);
    }
}


//Question3
public class ResourceManager : IDisposable
{

    public bool IsDisposed { get; set; }
    public void Dispose()
    {
        IsDisposed = true;
    }
}


//Question4 and 5
public static class LinqProblems
{
    public static List<int> FilterAndDouble(List<int> ints)
    {
        return ints.Where(i => i > 5 && i % 2 == 0)
                    .Select(i => i * 2)
                    .ToList();
    }

    public static Dictionary<string, int> GetTotalAmountByCategory(List<Sale> sales)
    {
        return sales.GroupBy(s => s.Category)
                    .Select(g =>
                            {
                                return (g.Key, g.Select(s =>
                                            {
                                                int sum = 0;
                                                sum += s.Amount;
                                                return sum;
                                            }).Sum()
                                );
                            }
                           )
                    .ToDictionary();
    }
}

public class Sale
{

    public string Category { get; set; }
    public int Amount { get; set; }


}

//Question6

public struct Money
{
    public int Amount { get; set; }
    public string Item2 { get; set; }

    public Money(int _item1, string _item2)
    {
        Amount = _item1;
        Item2 = _item2;
    }

    public static Money operator +(Money money1, Money money2) => new Money(money1.Amount + money2.Amount, money2.Item2);
    public static bool operator ==(Money money1, Money money2) => money1.Amount == money2.Amount;
    public static bool operator !=(Money money1, Money money2) => !(money1 == money2);

    public void Print()
    {
        System.Console.WriteLine($"{Amount} {Item2}");
    }
}



//Question7

public delegate string StringOperation();


public static class DelegateProblems
{
    public static string STRING{ get; set; }
    public static string ProcessString(string input, StringOperation stringOperation)
    {
        STRING = input;
        return stringOperation();
    }

    public static string ToUpper()
    {
        return STRING.ToUpper();
    }
    public static string ToLower()
    {
        return STRING.ToLower();
    }
}


//Question8


public static class LambdaProblems
{
    public static Func<string, int> GetStringLengthCalculator()=> (Mystring) => Mystring.Count();
}




//Question9



public delegate string DEL();
public class Publisher
{
    public event DEL Event;
    public List<string> ReceivedMessagesP { get; set; } = new();
    public void RaiseEvent(string input)
    {
        ReceivedMessagesP.Add(input);
        Event += () => input;
    }

}
public class Subscriber
{
    public Publisher Item1 { get; set; }
    public List<string> ReceivedMessages { get; set; } = new();
    public Subscriber(Publisher publisher)
    {
        Item1 = publisher;
        foreach (var item in publisher.ReceivedMessagesP)
            ReceivedMessages.Add(item);
    }
    public void Unsubscribe()=>ReceivedMessages.Clear();
}




//Question11

public class Closures
{
    public static Func<int> CreateCounter()
    {
        int Count = 0;
        return () => Count += 1;
    }
}


//Question12

public class SafeCounter
{
    public int Count { get; set; }
    public object obj { get; set; } = new();

    public void Increment()
    {
        lock (obj)
            Count++;
    }
}



//Question13

public class DataService
{
    public async Task<string> FetchDataAsync(string input)
    {
        await Task.Delay(1000);
        return $"Data for {input}";
    }
}


//Question14

public interface IEntity<T>
{
    public Guid Id { get; set; }
    public T CreateNew();    
}
public class Repository<T> where T : IEntity<T> , new()
{
    public static T Item { get; set; } = new();

    public T CreateNew()
    {
        return Item.CreateNew();
    }
}
public class Customer : IEntity<Customer>
{
    public Guid Id{ get; set; }

    public Customer CreateNew()=> new Customer();
}
public class Order:IEntity<Order>
{
    public Guid Id{ get; set; }

    public Order CreateNew()=> new Order();
}



//Question15

public abstract class IStage<T>
{
    protected IStage<T> Nextstage { get; set; }
    public abstract string Handle(string input);
    public IStage<T> SetNext(IStage<T> stage)
    {
        Nextstage = stage;
        return Nextstage;
    }
}
public class TrimStage : IStage<string>
{
    public override string Handle(string input)
    {
        string Myout = input.Trim(' ', '\t' , '\n','\r');
        if (Nextstage != null)
            return Nextstage.Handle(Myout);
        return Myout;
    }
}
public class UpperStage : IStage<string>
{
    public override string Handle(string input)
    {
        string Myout = input.ToUpper();
        if (Nextstage != null)
            return Nextstage.Handle(Myout);
        return Myout;
    }
}
public class SuffixStage : IStage<string>
{
    public static string Suffix{get;set;}

    public SuffixStage(string input)=>Suffix = input;
    public override string Handle(string input)
    {
        string Myout = input + Suffix;
        if (Nextstage != null)
            return Nextstage.Handle(Myout);
        return Myout;
    }
}