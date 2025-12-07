using System;

class Program
{
    static void Main(string[] args)
    {
        Testing();




        void Testing()
        {
        Console.WriteLine("Hello FinalProject World!");
        Dice d1 = new Dice(6 ,3,0,false);
        Dice d2 = new Dice(6,3,0,false);
        Dice d3 = new Dice(6,3,0,false);
        Dice d4 = new Dice(6,3,0,false);
        

        d1.RollDice();
        d2.RollDice();
        d3.RollDice();
        d4.RollDice();
        }
    }
}