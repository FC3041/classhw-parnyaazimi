namespace E3;

class Program
{
    static void Main(string[] args)
    {
        var publisher = new Publisher();
        var subscriber = new Subscriber(publisher);
        var anotherSubscriber = new Subscriber(publisher);

        // Act
        publisher.RaiseEvent("First Message");
        publisher.RaiseEvent("Second Message");

        // Unsubscribe one
        subscriber.Unsubscribe();
        publisher.RaiseEvent("Third Message");
        // publisher.Print();

        foreach (var item in subscriber.ReceivedMessages)
        {
            System.Console.WriteLine(item);
        }


        IStage<string> tB = new TrimStage();
        IStage<string> sB = new SuffixStage("-ok");
        IStage<string> uB = new UpperStage();
        tB.SetNext(sB).SetNext(uB);
        System.Console.WriteLine(tB.Handle("  hello  "));
    }
}
