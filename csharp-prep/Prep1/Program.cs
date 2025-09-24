using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();
        Console.Write("What is your last name? ");
        string last = Console.ReadLine();
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        Console.WriteLine($"Your name is {textInfo.ToTitleCase(last)}, {textInfo.ToTitleCase(first)} {textInfo.ToTitleCase(last)}.");
    }
}