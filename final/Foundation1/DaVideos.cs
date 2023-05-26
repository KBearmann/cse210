public class Video
{
    public Video(string title, string author, string length)
    {

        _title = title;
        _author = author;
        _length = length;
    }
    string _title;
    string _author;
    string _length;

    public List<Comment> commentList = new List<Comment>();

    public void Comments()
    {
        //returns the number of comments
        int count = commentList.Count();
        foreach (Comment comment in commentList)
        {
            comment.DisplayComments();
        }
        Console.WriteLine($"{count} comments\n");
    }

    public void AddComment(string _name, string _comment)
    {
        commentList.Add(new Comment(_name, _comment));
    }

    public void VideoInfo()
    {
        Console.WriteLine($"{_title}, {_author}, {_length}");
    }
}
