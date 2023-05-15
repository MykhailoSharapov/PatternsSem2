using Lab_6.Entities;

namespace Lab_6;

public class Visitor : IVisitor
{
    public int VisitCompany(Company company)
    {
        int totalSalary = 0;
        Console.WriteLine($"Company: {company.Name}");
        foreach (var employee in company.Departments)
        {
            totalSalary += VisitDepartment(employee);
        }

        Console.WriteLine($"Total salary: {totalSalary} $");
        return totalSalary;
    }

    public int VisitDepartment(Department department)
    {
        int totalSalary = 0;
        Console.WriteLine($"Department: {department.Name}");
        foreach (var employee in department.Employees)
        {
            totalSalary += VisitEmployee(employee);
        }

        Console.WriteLine($"Total salary: {totalSalary} $");
        return totalSalary;
    }

    public int VisitEmployee(Employee employee)
    {
        Console.WriteLine($"Name: {employee.Name}, salary: {employee.Salary} $");
        return employee.Salary;
    }
}

