using Lab_1.Interfaces;

namespace Lab_1;

public class PartInformation : IPartInformation
{
    public void ShowPart(IPartIterator iterator)
    {
        while (iterator.HasNext())
        {
            IPart place = iterator.Next();
            Console.WriteLine(place);
        }
    }
}

