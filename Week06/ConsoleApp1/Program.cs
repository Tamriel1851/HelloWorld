using System;
using System.IO;

class Program
{
    static void Main()
    {
        const int numCount = 10;
        int[] numbers = new int[numCount];

        Console.WriteLine("Please enter 10 numbers:");

        for (int i = 0; i < numCount; i++)
        {
            Console.Write($"Number {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                // Number is valid
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                i--; // Decrement i to re-enter the current number
            }
        }

        string numberString = string.Join(" ", numbers);

        // Save the numbers to a file
        File.WriteAllText("numbers.txt", numberString);

        Console.WriteLine("Numbers saved to numbers.txt.");
    }
}
