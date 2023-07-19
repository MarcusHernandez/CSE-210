public class Comment
{
    private string _writer;
    private string _commentText;

    public Comment(string writer, string commentText)
    {
        _writer = writer;
        _commentText = commentText;
    }

    public string GetComment()
    {
        return $"\"{_commentText}\"\n{_writer}";
    }

    public bool HasComment(string user)
    {
        return _writer.ToUpper().Contains(user.ToUpper());
    }
}