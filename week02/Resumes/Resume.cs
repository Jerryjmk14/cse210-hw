public class Resume
{
    //member attributes
    public string _name;
    public List<Job> _jobs = new List<Job>();
    
    //method
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }

    }

    //constructor
    public Resume()
    {
    }
}