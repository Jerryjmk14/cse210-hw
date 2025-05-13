using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        int response;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter Number: ");
            response = int.Parse(Console.ReadLine());
            if (response != 0)
            {
                numbers.Add(response);
            }
        } while (response != 0);


        int sum = 0;
        float average = 0;
        int largestNum = 0;
        foreach (int num in numbers)
        {
            sum += num;
            average = ((float)sum) / numbers.Count;
            if (num > largestNum)
            {
                largestNum = num;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNum}");

    }
}