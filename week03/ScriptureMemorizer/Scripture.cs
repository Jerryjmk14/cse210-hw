public class Scripture
{
    //Attributes
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    //Constructors
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string reff=_reference.GetDisplayText();
        string texts = text;
       
        
        Console.WriteLine(reff + ":" + texts);
    }

    

    //methods
    public void HideRandomWords(int numberToHide)
    {
        
    }
    public string GetDisplayText()
    {
        string text = "";
        return text;
    }
    public bool IsCompletelyHidden()
    {
        return true;
    }
}