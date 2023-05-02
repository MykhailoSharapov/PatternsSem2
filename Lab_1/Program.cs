using Lab_1.Interfaces;

namespace Lab_1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Laboratory work №1. Iterator pattern");
        Console.WriteLine();

        List<IPart> places = new List<IPart>
        {
            new Part() {Name = "suspension", Cost = 150, Rating = 3},
            new Part() {Name = "wheel", Cost = 300, Rating = 5},
            new Part() {Name = "engine", Cost = 50, Rating = 2},
        };

        IPartAggregator aggregator = new PartAggregator(places);
        IPartInformation partInformation = new PartInformation();

        Console.WriteLine("ByUserOpinion:");
        partInformation.ShowPart(aggregator.ByUserOpinion());

        Console.WriteLine();
        Console.WriteLine("CatalogRecommendation:");
        partInformation.ShowPart(aggregator.CatalogRecommendation());

        Console.WriteLine();
        Console.WriteLine("DealerRecommendation:");
        partInformation.ShowPart(aggregator.DealerRecommendation());
    }
}
