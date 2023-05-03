using Lab_4;

class Program
{
    static void Main(string[] args)
    {
        Order order = new Order();
        order.Delevery = new SelfDelivery();
        Console.WriteLine($"Self delivery: {order.GetResultingPrice()}");
        order.Delevery = new ExpressDelivery();
        Console.WriteLine($"Express delivery: {order.GetResultingPrice()}");
        order.Delevery = new VIPDelivery();
        Console.WriteLine($"VIP delivery: {order.GetResultingPrice()}");
    }
}
