using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        List<int> numbers = new List<int>();

        int number;
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            
            numbers.Add(number);


        } while (number != 0);

        numbers.Remove(0);

        Console.WriteLine($"the sum is: {numbers.Sum()}");
        Console.WriteLine($"the average is: {numbers.Average()}");
        Console.WriteLine($"the largest number is: {numbers.Max()}");

    }
}