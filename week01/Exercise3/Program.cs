using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

         Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 101);

        // Ask user for a guess
        int guess = 0;

        while (guess != magicNum)
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);

            if (guess > magicNum )
            {
                Console.WriteLine("Lower");
            }
            else if (guess == magicNum )
            {
                Console.WriteLine("You guessed it!"); 
            }
            else
            {
                Console.WriteLine("Higer"); 
            }
        }

    }
}