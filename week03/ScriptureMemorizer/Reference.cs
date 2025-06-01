public class Reference
{
    //Attributes
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    //Constructor
    // Constructor for a single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    // Constructor for a multiple verses
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }


    //Methods
    public string GetDisplayText()
    {
        string displayReference;
        if (_endVerse >= 1)
        {
            displayReference = _book + " " + _chapter + ":" + _verse + "-" + _endVerse;
            return displayReference; 
        } else 
        {
            displayReference = _book + " " + _chapter + ":" + _verse;
            return displayReference; 
        }
        
    }
    //Possible getters and setters
}