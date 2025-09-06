using System;

class Program
{
    static void Main()
    {
        Console.Title = "Multiplication Table - Day 3";
        Console.WriteLine("=== Multiplication Table Generator ===\n");

        // Read number from user
        int n = ReadInt("Enter a number (e.g., 5): ", 1, 20);

        Console.WriteLine($"\nMultiplication Table for {n}:\n");

        // Generate table from 1 to 10
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i,2} = {n * i,3}");
        }

        Console.WriteLine("\n=== Full Table (1–10) ===\n");

        // Nested loop for full 10x10 table
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j,4}");
            }
            Console.WriteLine();
        }
    }

    // Helper method for safe input
    static int ReadInt(string prompt, int min, int max)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int value))
            {
                if (value >= min && value <= max)
                    return value;
                Console.WriteLine($"Please enter a number between {min} and {max}.");
            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");
            }
        }
    }
}
