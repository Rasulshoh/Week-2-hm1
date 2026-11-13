using System.Globalization;

public class Employee
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Position { get; set; } = string.Empty;
    public decimal Salary { get; private set; }

    public void SetSalary(decimal salary)
    {
        Salary = salary;
    }

    public decimal GetSalary()
    {
        return Salary;
    }

    public string GetInfo()
    {
        return $"FirstName: {FirstName}{Environment.NewLine}" +
               $"LastName: {LastName}{Environment.NewLine}" +
               $"Age: {Age}{Environment.NewLine}" +
               $"Position: {Position}{Environment.NewLine}" +
               $"Salary: {Salary.ToString("0.0", CultureInfo.InvariantCulture)}";
    }
}
