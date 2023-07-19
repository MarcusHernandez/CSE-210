public class Video
{
    private string _author;
    private string _title;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string author, string title, int length)
    {
        _author = author;
        _title = title;
        _length = length;
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void Display()
    {
        Console.WriteLine($"{_title}, by {_author}\nLength: {_length} seconds");
        if (_comments.Count > 0)
        {
            Console.WriteLine($"Number of Comments: {_comments.Count}");
            foreach (Comment comment in _comments)
            {
                Console.WriteLine(comment.GetComment());
            }
        }
        else
        {
            Console.WriteLine("[There are no Comments on this video yet.]");
        }
    }
}
