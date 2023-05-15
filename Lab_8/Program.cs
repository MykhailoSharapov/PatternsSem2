using Lab_8.Builders;
using Lab_8.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        IQueryBuilder queryBuilder = new PostgreSqlQueryBuilder();
        string postgreSqlQuery = queryBuilder.Select("Cars").Where("type = Sport").Limit(10).GetSql();
        Console.WriteLine(postgreSqlQuery);

        queryBuilder = new MySqlQueryBuilder();
        string mySqlQuery = queryBuilder.Select("Parts").Where("cost = 700").Limit(5).GetSql();
        Console.WriteLine(mySqlQuery);
    }
}
