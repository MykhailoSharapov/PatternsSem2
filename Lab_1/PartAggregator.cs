using Lab_1.Interfaces;
using Lab_1.Iterators;

namespace Lab_1;

public class PartAggregator : IPartAggregator
{
    private List<IPart> _places;

    public PartAggregator(List<IPart> places)
    {
        _places = places;
    }


    public IPartIterator CatalogRecommendation()
    {
        // recommendation by distance
        _places = _places.OrderBy(x => x.Cost).ToList();
        return new PartIterator(this);
    }

    public IPartIterator DealerRecommendation()
    {
        // recommendation by rating
        _places = _places.OrderBy(x => x.Rating).ToList();
        return new DealerRecomendationIterator(this);
    }

    public IPartIterator ByUserOpinion()
    {
        // recommendation by name
        _places = _places.OrderBy(x => x.Name).ToList();
        return new UserOpinionIterator(this);
    }

    public int Count => _places.Count;

    public IPart this[int index] => _places[index];
}
