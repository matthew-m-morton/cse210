using System;
using System.IO;

// 1 extra thing that I did was make a DisplayFileNames function that lists the existing .csv files.
// This function helps the user refence existing filenames while saving and loading to file.

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Journal Program!");
        int choice;
        Journal j1 = new Journal();
        do
        {
            choice = DisplayMenu();


            if (choice == 1)
            {
                j1._entries.Add(j1.WriteEntry());
                Console.WriteLine("Your entry has been added to the Journal.");
            }


            else if (choice == 2)
            {
                j1.Display();
            }


            else if (choice == 3)
            {
                j1 = Load();
                Console.WriteLine("Your Journal has been loaded");
            }


            else if (choice == 4)
            {

                Save(j1);

                Console.WriteLine("Your journal has been saved.");

            }

        } while (choice != 5);




        // Testing();


    }

    static int DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
        Console.Write("What would you like to do? ");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }

    static void DisplayFileNames()
    {
        string folderPath = Directory.GetCurrentDirectory();
        string[] textFiles = Directory.GetFiles(folderPath, "*.csv");
        foreach (string file in textFiles)
        {
            Console.WriteLine($"{Path.GetFileName(file)}");
        }

    }

    static Journal Load()
    {


        Journal journalFromFile = new Journal();

        Console.WriteLine("What File would you like to Load?");
        DisplayFileNames();


        string selectedFile = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(selectedFile);

        foreach (string line in lines)
        {
            Entry e1 = new Entry();
            string[] parts = line.Split("~~");
            e1._date = parts[0];
            e1._prompt = parts[1];
            e1._response = parts[2];
            journalFromFile._entries.Add(e1);
        }


        return journalFromFile;
    }

    static void Save(Journal journal)
    {
        Console.WriteLine("Would you like to save to an existing file? (Y/N) ");
        string answer = Console.ReadLine();
        if (answer == "Y" || answer == "Yes" || answer == "y" || answer == "yes")
        {
            DisplayFileNames();
        }
        Console.WriteLine("Please choose a file name.");
        string savefile = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(savefile))
        {
            foreach( Entry entry in journal._entries)
            {
                outputFile.WriteLine($"{entry._date}~~{entry._prompt}~~{entry._response}");
            }
        }

    }

    static void Testing()
    {
        Entry e1 = new Entry();
        e1._response = "this is a response test";
        e1._prompt = "response";
        e1._date = "todays date";

        Journal j1 = new Journal();
        j1._entries.Add(e1);
        j1.Display();

        Prompt p1 = new Prompt();
        p1.GeneratePrompt();
    }
}