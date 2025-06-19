public class BreathingActivity : Activity
{

    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        
    }

    public void Run()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine($"{_description}");
        Thread.Sleep(1500);
        Console.WriteLine("Breath in...");
        Thread.Sleep(1500);
        Console.WriteLine("Breath out...");
        
    }
    
}