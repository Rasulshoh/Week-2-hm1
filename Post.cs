public class Post
{
    public string Text = string.Empty;
    public int Likes;
    public List<string> Comments = new();

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
