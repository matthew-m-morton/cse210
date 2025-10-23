using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures;
        scriptures = MakeScriptures("scriptures.csv");
        Scripture chosenScripture = ScriptureSelection(scriptures);
        Memorize(chosenScripture);



    }

    static Scripture ScriptureSelection(List<Scripture> scriptures)
    {
        Console.Clear();
        int selection;
        while (true)
        {
            ScriptureSelectionMenu(scriptures);
            string input = Console.ReadLine();

            if (int.TryParse(input, out selection))
            {
                if (selection >= 1 && selection <= scriptures.Count)
                {
                    break;
                }
            }
            Console.Clear();
            Console.WriteLine("!!!!Invalid choice. Number nust be listed!!!!");
        }
        Scripture selectedScripture = scriptures[selection - 1];
        return selectedScripture;
    }
    
    static void ScriptureSelectionMenu(List<Scripture> scriptures)
    {
        Console.WriteLine("Which scripture would you like to memorize? (type number)");

        for (int i = 0; i < scriptures.Count; i++)
        {
            Console.WriteLine($"{i + 1}) {scriptures[i].GetReference()}");
        }
    }

    static List<Scripture> MakeScriptures(string fileName)
    {
        List<Scripture> s1 = new List<Scripture>();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Scripture scripture = new Scripture(line);
            s1.Add(scripture);
        }

        return s1;
    }

    static void Memorize(Scripture scripture)
    {
        while (true)
        {
            Console.Clear();
            scripture.Display();

            Console.WriteLine("\n\nPress Enter to continue or type 'quit' to finish");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            int countVisibleWords = scripture.WordCountSeen();

            if (countVisibleWords == 0) { break; }


            if (countVisibleWords > 3)
            {
                scripture.HideWords(3);
            }
            else
            {
                scripture.HideWords(countVisibleWords);
            }
        }
    }

}