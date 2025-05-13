using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

         // call each function
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNumber);
        DisplayResult(userName, squaredNumber);
    }

    // function to display welcome message
    static void DisplayWelcome ()
    {
       Console.WriteLine("Welcome to the program."); 
    }
    //Function to ask for and returns the user's name (as a string)
    // 
    static string PromptUserName()
    {
        Console.Write("Please enter your full name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    //function to ask for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
    }
    //function to accept an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }
    //function to accept the user's name and the squared number and displays them.
    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is: {number}");
    }
}