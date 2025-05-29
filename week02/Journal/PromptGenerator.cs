public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    
    public PromptGenerator()
    {}

    public string GetRandomPrompts()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What advice did I receive today?");
        _prompts.Add("What goals did I accomplish today?");
        
        // generate and return a random prompts
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        return randomPrompt;
    }

}