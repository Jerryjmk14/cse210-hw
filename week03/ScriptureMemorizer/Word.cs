public class Word
{
    private string _text;
    private bool _isHidden;

    //Constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    //Methods
    // Hide the word by setting IsHidden to true
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        _isHidden = true;
        return _isHidden;
    }
    public string GetDisplayText()
    { 
        return _text;
    }
}