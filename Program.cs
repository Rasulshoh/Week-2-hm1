// Task 1
Person person = new Person()
{
    FirstName = ReadText("Enter your FirstName: "),
    LastName = ReadText("Enter your LastName: "),
    Age = ReadInt("Enter your Age: ")
};
Console.WriteLine(person.GetInfo());

// Task 2
Post post = new Post();
post.SetPost("It is Post");
post.AddLike();
post.AddLike();
post.AddComment("Super");
post.AddComment("Great");
Console.WriteLine(post.GetInfo());

// Task 3
Player player = new Player()
{
    Name = ReadText("Enter player's name: "),
    Number = ReadInt("Enter player's number: "),
    Position = ReadText("Enter player's position: "),
    Team = ReadText("Enter player's team: ")
};
Console.WriteLine(player.GetInfo());
player.ScoreGoal();
player.AssistGoal("Neymar");

// Task 4
Employee employee = new Employee()
{
    FirstName = ReadText("Enter employee's FirstName: "),
    LastName = ReadText("Enter employee's LastName: "),
    Age = ReadInt("Enter employee's Age: "),
    Position = ReadText("Enter employee's Position: ")
};
employee.SetSalary(ReadDecimal("Enter employee's Salary: "));
Console.WriteLine(employee.GetInfo());

employee.SetSalary(ReadDecimal("Set a new Salary: "));
Console.WriteLine(employee.GetInfo());

static string ReadText(string prompt)
{
    Console.Write(prompt);
    return Console.ReadLine() ?? string.Empty;
}

static int ReadInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine() ?? string.Empty);
}

static decimal ReadDecimal(string prompt)
{
    Console.Write(prompt);
    return decimal.Parse(Console.ReadLine() ?? string.Empty);
}
