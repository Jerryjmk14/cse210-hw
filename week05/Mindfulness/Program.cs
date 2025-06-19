using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        Console.WriteLine("Welcome to the Mindfulness Program.");

        int response;
    
        do
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            Console.Write("> ");
            response = int.Parse(Console.ReadLine());

            if (response == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 15);

                breathingActivity.Run();

            }

            else if (response == 2)
            {
                // ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 15);                
            }

            else if (response == 3)
            {
                // ListingActivity listingActivity = new ListingActivity("Reflecting Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 15); 
            }


        } while (response != 4); // Quit the program!

    }

}