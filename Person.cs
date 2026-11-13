public class Person
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Age { get; set; }

    public string GetInfo()
    {
        return $"FirstName: {FirstName}{Environment.NewLine}" +
               $"LastName: {LastName}{Environment.NewLine}" +
               $"Age: {Age}";
    }
}