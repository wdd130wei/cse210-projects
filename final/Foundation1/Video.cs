
public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
    public void AddComment(string commenter, string comment) 
    {
        _comments.Add(new Comment(commenter, comment));
    }
    public string GetTitle() 
    {
        return _title;
    }

    public string GetAuthor() 
    {
        return _author;
    }

    public int GetLength() 
    {
        return _length;
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}