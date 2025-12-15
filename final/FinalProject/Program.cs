using System;
using System.Net;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        string status = "";
        List<Character> characters = LoadCharacters();

        while(status != "exit")
        {
            Menu menu = new Menu(characters);
            menu.StatMenu();
            Console.WriteLine($"Would you like to roll initiative? (yes) \n Or you can type exit to leave. ");
            status = Console.ReadLine();
            if (status == "yes")
            {
                menu.RollInitiative();
            }
        
        }
    }
    // static void TestDice()
    // {
    //     Console.Clear();
    //     Console.WriteLine("Hello FinalProject World!");
    //     Dice d1 = new Dice(6,3,0);
    //     Dice d2 = new Dice(6,3,0);
    //     Dice d3 = new Dice(6,3,0);
    //     Dice d4 = new Dice(6,3,0);
        

    //     d1.RollDice();
    //     d2.RollDice();
    //     d3.RollDice();
    //     d4.RollDice();
    // }
    static List<Character> LoadCharacters()
    {
        List<Character> characterstrings = new List<Character>();

        string[] lines = System.IO.File.ReadAllLines("Characters.csv");

        foreach(string line in lines)
        {
            string[] parts = line.Split("~~~");
            // parse scores
            int[] scores = parts[5].Trim('[', ']').Split(',').Select(int.Parse).ToArray();

            // creating attacks list
            string[] wholeAttackStrings = parts[6].Split("|");
            List<Attack> attacks =  new List<Attack>();
            foreach(string attackString in wholeAttackStrings)
            {
                string[] attackParts = attackString.Split("~~");
                if (attackParts[0] == "Melee")
                {
                    attacks.Add(new MeleeAttack(attackParts[1],attackParts[2]));
                }
                else if (attackParts[0] == "Ranged")
                {
                    attacks.Add(new RangedAttack(attackParts[1],attackParts[2], int.Parse(attackParts[3]), int.Parse(attackParts[4])));
                }
            }
        


            if (parts[0] == "Player")
            {
                // parse spell slots and proficiencies
                int[] spellSlots = parts[10].Trim('[', ']').Split(',').Select(int.Parse).ToArray();
                bool[] proficiencies = parts[11].Trim('[', ']').Split(',').Select(bool.Parse).ToArray();
                characterstrings.Add(new PlayerCharacter(parts[1],int.Parse(parts[2]),int.Parse(parts[3]),int.Parse(parts[4]),scores,attacks,int.Parse(parts[7]), int.Parse(parts[8]),parts[9],spellSlots,proficiencies));
            }
            else if (parts[0] == "Enemy")
            {
                characterstrings.Add(new EnemyCharacter(parts[1],int.Parse(parts[2]),int.Parse(parts[3]),int.Parse(parts[4]),scores,attacks,int.Parse(parts[7]), int.Parse(parts[8]), parts[9]));                
            }
        }

        return characterstrings;
    }
}