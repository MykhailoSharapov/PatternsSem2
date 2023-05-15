using Lab_5.Models;

namespace Lab_5.Repositories;

public class UserRepository : IRepository
{
    public Item Update(Item item) => item;

    public Item Get(Guid id)  => new User { Email = "321@ukr.net" };
}

