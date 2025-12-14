using System;

class Program
{
    static void Main(string[] args)
    {
        TestMenu();
    }
        static void TestMenu()
    {
        Menu menu = new Menu();
        menu.StatMenu();
    }
    static void TestDice()
    {
        Console.Clear();
        Console.WriteLine("Hello FinalProject World!");
        Dice d1 = new Dice(6,3,0);
        Dice d2 = new Dice(6,3,0);
        Dice d3 = new Dice(6,3,0);
        Dice d4 = new Dice(6,3,0);
        

        d1.RollDice();
        d2.RollDice();
        d3.RollDice();
        d4.RollDice();
    }
}