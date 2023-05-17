
public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;

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
    public string Title 
    {
        get { return _title; }
    }

    public string Author 
    {
        get { return _author; }
    }

    public int Length 
    {
        get { return _length; }
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