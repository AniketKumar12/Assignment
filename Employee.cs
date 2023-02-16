using System;

public class Employee
{
    private string Id;
    private string Name;
    private string DepartmentName;

    public Employee(string id, string name, string departmentName)
    {
       this.Id = id;
       this.Name = name;
       this.DepartmentName = departmentName;
    }

    public string GetId()
    {
        return Id;
    }

    public string GetName()
    {
        return Name;
    }

    public string GetDepartmentName()
    {
        return DepartmentName;
    }

    public void UpdateId(string id)
    {
        Id = id;
    }

    public void UpdateName(string name)
    {
        Name = name;
    }

    public void UpdateDepartmentName(string departmentName)
    {
        DepartmentName = departmentName;
    }
    
    {
        String id;
        String name;
        string departmentName;
        Console.WriteLine("Enter the employee id: ");
         id = Console.ReadLine();

        Console.WriteLine("Enter the employee name: ");
        name = Console.ReadLine();

        Console.WriteLine("Enter the employee department name: ");
         departmentName = Console.ReadLine();

        Employee employee = new Employee(id, name, departmentName);

        Console.WriteLine(employee.GetId());
        Console.WriteLine(employee.GetName());
        Console.WriteLine(employee.GetDepartmentName());
    }
}