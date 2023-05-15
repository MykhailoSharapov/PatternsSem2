using Lab_5.Models;

namespace Lab_5.Repositories;

public class OrderRepository : IRepository
{
    public Item Update(Item item) => item;

    public Item Get(Guid id) => null;
}

