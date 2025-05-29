public class Job
{
    //member attributes
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    
    //method
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
    //constructor
    public Job()
    {
    }
}