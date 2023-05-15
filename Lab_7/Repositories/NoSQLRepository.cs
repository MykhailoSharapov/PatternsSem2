using Lab_7.Interfaces;

namespace Lab_7.Repositories;

public class NoSQLRepository : IRepository
{
    private static IRepository Instance;

    public static IRepository GetInstance()
    {
        Instance ??= new NoSQLRepository();
        return Instance;
    }

    public void Create(IEntity entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public IEntity Read(Guid id)
    {
        throw new NotImplementedException();
    }

    public void Update(IEntity entity)
    {
        throw new NotImplementedException();
    }
}
