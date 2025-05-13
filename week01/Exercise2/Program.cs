using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        // Program to print students grades
        Console.Write("Please enter your grade percentage: ");
        string userInput = Console.ReadLine();
        int gradePercent = int.Parse(userInput);

        string letter;

        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");
        
        // output result message
        if (gradePercent >= 70)
        {
            Console.WriteLine("Hurray You Passed!");
        }
        else
        {
            Console.WriteLine("You can do better next time!");
        }
    }
}