using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        // Split input based on spaces
        string[] words = input.Split(' ');

        // Regular Expression for operators (+, -, *, /)
        Regex regex = new Regex(@"^[+\-*/]$");

        Console.WriteLine("Operators found:");
        foreach (string word in words)
        {
            if (regex.IsMatch(word))
            {
                Console.Write(word + " ");
            }
            else
            {
                Console.WriteLine($"Invalid: {word}");
            }
        }
    }
}