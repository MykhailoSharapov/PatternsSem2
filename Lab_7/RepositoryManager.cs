using Lab_7.Interfaces;
using Lab_7.Repositories;

namespace Lab_7
{
    public class RepositoryManager
    {
        public static IRepository GetRepository(string name)
        {
            return name switch
            {
                nameof(NoSQLRepository) => NoSQLRepository.GetInstance(),
                nameof(SQLRepository) => SQLRepository.GetInstance(),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
