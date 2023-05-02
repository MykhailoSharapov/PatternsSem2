using Lab_1.Interfaces;

namespace Lab_1;

public class Part : IPart
{
    public string Name { get; set; }
    public int Cost { get; set; }
    public int Rating { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Cost: {Cost}km, Rating: {Rating}";
    }
}

