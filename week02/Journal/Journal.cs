using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    // Add new entry to List
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    // Display all entries
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Entry entry1 = new Entry();
            entry1._promptText = entry._promptText;
            entry1._entryText = entry._entryText;
            entry1.Display();
        }
    }
    // Save entries to file
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // add text to the file with the WriteLine method
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} - Prompt: {entry._promptText}");
                outputFile.WriteLine(entry._entryText);
                outputFile.WriteLine("");
            }
        }
    }
    // Read and display entries from file
    public void LoadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
    
}