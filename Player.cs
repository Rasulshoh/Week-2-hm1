public class Player
{
    public string Name = string.Empty;
    public int Number;
    public string Position = string.Empty;
    public string Team = string.Empty;

    public void ScoreGoal()
    {
        Console.WriteLine($"Player {Name} scores a goal!");
    }

    public void AssistGoal(string playerName)
    {
        Console.WriteLine($"{Name} assists a goal for {playerName}.");
    }

    public string GetInfo()
    {
        return $"Name: {Name}{Environment.NewLine}" +
               $"Number: {Number}{Environment.NewLine}" +
               $"Position: {Position}{Environment.NewLine}" +
               $"Team: {Team}";
    }
}
