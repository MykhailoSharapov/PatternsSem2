using Lab_4.Interfaces;

namespace Lab_4;

public class VIPDelivery : IDelivery
{
    public int Cost()
    {
        return new Random().Next();
    }
}

