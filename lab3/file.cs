using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a floating-point number:");
        string input = Console.ReadLine();

        Regex floatRegex = new Regex(@"^\d{1,6}(\.\d{1,6})?$");

        if (floatRegex.IsMatch(input))
            Console.WriteLine("Valid floating-point number.");
        else
            Console.WriteLine("Invalid floating-point number.");
    }
}
