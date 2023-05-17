
public class Comment
{
    string _commenter;
    string _comment;

    public Comment(string commenter, string comment)
    {
        _commenter = commenter;
        _comment = comment;
    }

    public string GetCommenter
    {
        get { return _commenter;}
    }

    public string GetComment
    {
        get { return _comment;}
    }
}