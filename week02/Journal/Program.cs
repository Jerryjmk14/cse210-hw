using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Console.WriteLine("Welcome to the Journal Program.");

        int response;
        Journal myJournal = new Journal();

        do
        {
            Console.WriteLine("Please select one of the following choices,");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            Console.Write("> ");
            response = int.Parse(Console.ReadLine());

            if (response == 1)
            {
                // generate and display random prompt
                PromptGenerator promptGenerator = new PromptGenerator();
                Entry myEntry = new Entry();
                myEntry._promptText = promptGenerator.GetRandomPrompts();
                Console.WriteLine(myEntry._promptText);
                Console.Write("> ");
                myEntry._entryText = Console.ReadLine();
                //add entry to journal
                myJournal.AddEntry(myEntry);
            }

            else if (response == 2)
            {
                // Display all entries
                myJournal.DisplayAll();                
            }

            else if (response == 3) 
            {
                // Read and display entries from file
                Console.WriteLine("What is the filename?");
                Console.Write("> ");
                string file = Console.ReadLine();
                myJournal.LoadFromFile(file);
            }

            else if (response == 4) 
            {
                // Save entries to file
                Console.WriteLine("What is the filename?");
                Console.Write("> ");
                string file = Console.ReadLine();
                myJournal.SaveToFile(file);
            }

        } while (response != 5); // Quit the program!

    }
}