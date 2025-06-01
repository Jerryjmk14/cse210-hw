public class Video
{
    // member variables
    string _title = "";
    string _author = "";
    int _length = 0;
    List<Comment> _comments = new List<Comment>();
    // List<Videos> _youTubeVideos = new List<Videos>();

    //constructors
    public Video(string title, string author, int length )
    {
        _title = title;
        _author = author;
        _length = length;
    }

    //methods
    public void AddComments(Comment commentText)
    {
        _comments.Add(commentText);
    }
    public int NumberOfComments()
    {
        int count = 0;
        foreach (Comment comment in _comments)
        {
            count ++;
        }
        return count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title:{_title}");
        Console.WriteLine($"Author:{_author}");
        Console.WriteLine($"Length:{_length} seconds");
        Console.WriteLine($"Number of Comments: {NumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        //Add a blank line readability
        Console.WriteLine();

    }
}