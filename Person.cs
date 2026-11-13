public class Person
{
    public string FirstName = string.Empty;
    public string LastName = string.Empty;
    public int Age;

    public string GetInfo()
    {
        return $"FirstName: {FirstName}{Environment.NewLine}" +
               $"LastName: {LastName}{Environment.NewLine}" +
               $"Age: {Age}";
    }
}