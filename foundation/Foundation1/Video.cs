using System;

public class Video
{
    public string _title { get; set; }
    public string _author { get; set; }
    public int _length { get; set; }
    public List<Comment> Comments { get; set;} = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetNumComments()
    {
        return Comments.Count;
    }
}