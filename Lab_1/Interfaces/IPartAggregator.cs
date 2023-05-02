namespace Lab_1.Interfaces;

public interface IPartAggregator
{
    IPartIterator CatalogRecommendation();
    IPartIterator DealerRecommendation();
    IPartIterator ByUserOpinion();
    int Count { get; }
    IPart this[int index] { get; }
}

