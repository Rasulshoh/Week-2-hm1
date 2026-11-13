using System.Globalization;

public class Employee
{
    public string FirstName = string.Empty;
    public string LastName = string.Empty;
    public int Age;
    public string Position = string.Empty;
    public decimal Salary;

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
