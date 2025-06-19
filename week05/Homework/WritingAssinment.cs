public class WritingAssignment : Assignment
{
    private string _title;

    // constructor
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        // set specific variables to the WritingAssignment class
        _title = title;
    }

    public string GetWritingInformation()
    {
        
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}