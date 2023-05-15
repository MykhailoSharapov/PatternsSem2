using Lab_7;
using Lab_7.Interfaces;
using Lab_7.Repositories;

class Program
{
    static void Main(string[] args)
    {
        var mongoDBRepository = RepositoryManager.GetRepository(nameof(NoSQLRepository));
        var postgreSQLRepository = RepositoryManager.GetRepository(nameof(SQLRepository));

        if (mongoDBRepository is NoSQLRepository)
        {
            Console.WriteLine("NoSQLRepository is NoSQLRepository type");
        }

        if (postgreSQLRepository is SQLRepository)
        {
            Console.WriteLine("SQLRepository is SQLRepository type");
        }
    }
}
