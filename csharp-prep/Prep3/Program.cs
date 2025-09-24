using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "YES";
        while (response.ToUpper() == "YES")
        {
            int magicNumber = new Random().Next(1,100);
            int guess = -1;
            int count = 0;
            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                count ++;

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }

            } while (guess != magicNumber);

            Console.WriteLine($"That is correct!!! You got it in {count} guesses.");
            Console.Write("would you like to keep playing? (yes/no) ");
            response = Console.ReadLine();
        }
    }
}