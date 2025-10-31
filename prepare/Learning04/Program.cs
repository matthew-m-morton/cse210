using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        a1.GetSummary();

        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        a2.GetHomeworkList();

        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        a3.GetWritingInformation();
    }
}