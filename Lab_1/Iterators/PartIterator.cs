using Lab_1.Interfaces;

namespace Lab_1.Iterators;

public class PartIterator : IPartIterator
{
    private readonly IPartAggregator _parts;
    private int _index;

    public PartIterator(IPartAggregator parts)
    {
        _parts = parts;
    }

    public bool HasNext() => _index < _parts.Count;

    public IPart Next() => _parts[_index++];
}

