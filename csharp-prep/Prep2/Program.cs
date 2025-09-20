using System;

class Program
{
    static void Main(string[] args)
    {
        // Core requirement 1 & 3
        Console.Write("What is your grade percentage in this class? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Stretch Challenge 1-3
        string plusOrMinus = "";
        if (percentage < 95 && percentage >= 60)
        {
            if (percentage % 10 >= 7)
            {
                plusOrMinus = "+";
            }
            else if (percentage % 10 < 3)
            {
                plusOrMinus = "-";
            }
        }


        Console.WriteLine($"Your grade is a {letter}{plusOrMinus}");

        // Core requirement 2
        if (percentage > 70)
        {
            Console.WriteLine("You are Passing!!! Keep up the great work.");
        }
        else
        {
            Console.WriteLine("Sadly that is not a passing grade.\nIf you work hard next time I'm sure you will pass.");
        }

    }
}