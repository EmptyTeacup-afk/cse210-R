using System.Reflection.Metadata.Ecma335;

public class Comment
{
    public string _user { get; set; }
    public string _text { get; set; }

    public Comment(string user, string comment)
    {
        _user = user;
        _text = comment;

    }
}
