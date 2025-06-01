public class Comment
{
    // member variables
    string _userName;
    string _commentText;
    
    //constructor
    public Comment(string userName, string comment)
    {
        _userName = userName;
        _commentText = comment;
    }
    //methods
    public void DisplayComment()
    {
        Console.WriteLine($"Name:{_userName}, Comment: {_commentText}");
    }
}