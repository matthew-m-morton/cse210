using System;

class Program
{
    static void Main(string[] args)
    {
        TestMenu();
    }
    static void TestMenu()
    {
        Menu menu = new Menu(LoadCharacters());
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
    static List<Character> LoadCharacters()
    {
        List<Character> characterstrings = new List<Character>();

        string[] lines = System.IO.File.ReadAllLines("Characters.csv");

        foreach(string line in lines)
        {
            string[] parts = line.Split("~~");
            int[] scores = parts[5].Trim('[', ']').Split(',').Select(int.Parse).ToArray();
            if (parts[0] == "Player")
            {
                characterstrings.Add(new PlayerCharacter(parts[1],int.Parse(parts[2]),int.Parse(parts[3]),int.Parse(parts[4]),))
            }
            else if (parts[0] == "Enemy")
            {
                
            }
        }

        return characterstrings;
    }
}