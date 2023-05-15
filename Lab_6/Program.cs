
using Lab_6;
using Lab_6.Entities;

class Program
{
    static void Main(string[] args)
    {
        var employee1 = new Employee { Name = "Tom", Salary = 1100 };
        var employee2 = new Employee { Name = "Jim", Salary = 2030 };
        var employee3 = new Employee { Name = "Nick", Salary = 3400 };

        var department1 = new Department { Name = "First Dep", Employees = new List<Employee> { employee1, employee2, employee3 } };

        var employee4 = new Employee { Name = "Mike", Salary = 1400 };
        var employee5 = new Employee { Name = "Jack", Salary = 2300 };

        var department2 = new Department { Name = "Second Dep", Employees = new List<Employee> { employee4, employee5 } };

        var company = new Company { Name = "CompanyName", Departments = new List<Department> { department1, department2 } };

        var visitor = new Visitor();

        Console.WriteLine("-------------------------------");
        Console.WriteLine($"Employee report:{Environment.NewLine}");
        GetReport(employee1, visitor);
        Console.WriteLine("-------------------------------");

        Console.WriteLine($"Department report:{Environment.NewLine}");
        GetReport(department1, visitor);
        Console.WriteLine("-------------------------------");

        Console.WriteLine($"Company report:{Environment.NewLine}");
        GetReport(company, visitor);
        Console.WriteLine("-------------------------------");
    }

    private static void GetReport(IEntity entity, IVisitor visitor)
    {
        entity.Accept(visitor);
    }
}
