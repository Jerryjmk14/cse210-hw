using System.Collections.Generic;

public class ListingActivity : Activity
{
    protected int _count;
    protected List<string> _prompts;

    public ListingActivity(int count, List<string> prompts, string name, string description, int duration) : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }
    
    public void Run()
    {

    }
    private string GetRandomPrompt()
    {
        
        return _name;
    }

    private List<string> GetListFromUser() {
        return _prompts;
    }
}