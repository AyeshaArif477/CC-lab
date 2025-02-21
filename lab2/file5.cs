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

        // Regular Expression for variables (Starts with a letter, followed by up to 24 alphanumeric characters)
        Regex regex = new Regex(@"^[A-Za-z][A-Za-z0-9]{0,24}$");

        Console.WriteLine("Valid variables:");
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