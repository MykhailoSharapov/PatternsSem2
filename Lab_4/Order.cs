using Lab_4.Interfaces;

namespace Lab_4;

public class Order
{
    public IDelivery Delevery { get; set; }

    public int GetResultingPrice()
    {
        return new Random().Next() + Delevery.Cost();
    }
}

