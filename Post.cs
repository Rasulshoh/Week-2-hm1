public class Post
{
    public string Text { get; private set; } = string.Empty;
    public int Likes { get; private set; }
    public List<string> Comments { get; } = new();

    public void SetPost(string text)
    {
        Text = text;
        Likes = 0;
        Comments.Clear();
    }

    public void AddLike()
    {
        Likes++;
    }

    public void AddComment(string comment)
    {
        Comments.Add(comment);
    }

    public string GetInfo()
    {
        return $"Text = {Text}{Environment.NewLine}" +
               $"Likes : {Likes}{Environment.NewLine}{Environment.NewLine}" +
               $"Comments :{Environment.NewLine}{string.Join(Environment.NewLine, Comments)}";
    }
}
