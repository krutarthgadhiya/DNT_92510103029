using System;

// Interface
interface IPayable
{
    double CalculateSalary();
}

// Base Class
class Employee
{
    protected int empId;
    protected string name;

    public Employee(int empId, string name)
    {
        this.empId = empId;
        this.name = name;
    }

    public virtual void Display()
    {
        Console.WriteLine("\nEmployee ID : " + empId);
        Console.WriteLine("Employee Name : " + name);
    }
}

// Full-Time Employee Class
class FullTimeEmployee : Employee, IPayable
{
    private double monthlySalary;
    private double bonus;

    public FullTimeEmployee(int empId, string name, double monthlySalary, double bonus)
        : base(empId, name)
    {
        this.monthlySalary = monthlySalary;
        this.bonus = bonus;
    }

    public double CalculateSalary()
    {
        return monthlySalary + bonus;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Employee Type : Full-Time");
        Console.WriteLine("Monthly Salary : " + monthlySalary);
        Console.WriteLine("Bonus : " + bonus);
        Console.WriteLine("Total Salary : " + CalculateSalary());
    }
}

// Part-Time Employee Class
class PartTimeEmployee : Employee, IPayable
{
    private int hoursWorked;
    private double hourlyRate;

    public PartTimeEmployee(int empId, string name, int hoursWorked, double hourlyRate)
        : base(empId, name)
    {
        this.hoursWorked = hoursWorked;
        this.hourlyRate = hourlyRate;
    }

    public double CalculateSalary()
    {
        return hoursWorked * hourlyRate;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Employee Type : Part-Time");
        Console.WriteLine("Hours Worked : " + hoursWorked);
        Console.WriteLine("Hourly Rate : " + hourlyRate);
        Console.WriteLine("Total Salary : " + CalculateSalary());
    }
}

// Main Class
class Program
{
    static void Main(string[] args)
    {
        Employee[] employees = new Employee[2];

        employees[0] = new FullTimeEmployee(101, "Rahul", 50000, 5000);
        employees[1] = new PartTimeEmployee(102, "Priya", 120, 300);

        Console.WriteLine("===== Employee Payroll System =====");

        foreach (Employee emp in employees)
        {
            emp.Display();
        }

        Console.ReadLine();
    }
}
