public class ReflectingActivity : Activity
{
    protected List<string> _prompts;
    protected List<string> _questions;

     public ReflectingActivity(List<string> questions, List<string> prompts, string name, string description, int duration) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
        
        // Set other values here that are unique to the Reflecting Activity
    }
    
    public void Run (){

    }

    public string GetRandomPrompt() {
        return _name;
    } 

    public string GetRandomQuestion() {
        return _description;
    } 

    public void DisplayPrompt() {

    } 
    public void DisplayQuestions() {
        
    } 

}