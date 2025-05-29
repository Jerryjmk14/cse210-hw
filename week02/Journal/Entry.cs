public class Entry
{
    public string _date = DateTime.Now.ToString("dd/mm/yy");
    public string _promptText;
    public string _entryText;

    public Entry()
    {}

    public void Display()
    {
        Console.WriteLine($"{_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
    }

}