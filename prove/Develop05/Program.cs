using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        List<Goal> goals = new List<Goal>();
        Console.Clear();
        Console.WriteLine("Welcome to the Goal tracker.");


        while(choice != "6")
        {
            int score = CalculateScore(goals);
            Console.WriteLine($"You have {score} points.");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if(choice == "1"){goals = NewGoal(goals);}
            else if (choice == "2")
            { 
                ListGoal(goals);
                Console.WriteLine("press ENTER to continue...");
                Console.ReadLine();
                Console.Clear();
            }
            else if (choice == "3"){ SaveGoals(goals);}
            else if (choice == "4"){ goals = LoadGoals();}
            else if (choice == "5"){goals = RecordEvent(goals);}

        }
    }

    static List<Goal> NewGoal(List<Goal> goals)
    {
        string type = "";
        Console.Clear();
        Console.WriteLine("the types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to Create? ");
        type = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string title = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string desc = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if(type == "1")
        {
            Goal newGoal = new SimpleGoal(title,desc,points,false);
            goals.Add(newGoal);
        }
        else if(type == "2")
        {
            Goal newGoal = new EternalGoal(title,desc,points,false,0);
            goals.Add(newGoal);
        }
        else if(type == "3"){
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int bonusThreshold = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonusPoints = int.Parse(Console.ReadLine());

            Goal newGoal = new CheckListGoal(title,desc,points,false,0,bonusThreshold,bonusPoints);
            goals.Add(newGoal);
        }

        Console.Write("");
        Console.Write("");
        Console.Clear();
        return goals;

    }
    static void ListGoal(List<Goal> goals)
    {
        Console.Clear();
        Console.WriteLine("The goals are:");
        int count = 1;
        foreach (Goal goal in goals)
        {
            Console.Write(count);
            goal.Display();
            count ++;
        }
    }
    static void ListGoal(List<Goal> goals, bool status)
    {
        Console.Clear();
        int count = 1;
        foreach (Goal goal in goals)
        {
            bool goalStatus = goal.IsCompleted();
            if (goalStatus == status)
            {
                Console.Write(count);
                goal.Display();
                count ++;
            }
        }
    }
    static void SaveGoals(List<Goal> goals)
    {
        Console.Clear();
        Console.WriteLine("Would you like to save to an existing file? (Y/N) ");
        string answer = Console.ReadLine();
        string saveFile;
        if (answer == "Y" || answer == "Yes" || answer == "y" || answer == "yes")
        {
            saveFile = SelectedFileName();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("What would you like to name your new file?");
            saveFile = Console.ReadLine();
        }


        using (StreamWriter outputFile = new StreamWriter(saveFile))
        {
            foreach(Goal goal in goals )
            {
                outputFile.WriteLine(goal.ToString());
            }
        }      
    } 
    static string SelectedFileName()
    {
        int count = 1;
        Console.WriteLine("Files: ");
        string folderPath = Directory.GetCurrentDirectory();
        string[] textFiles = Directory.GetFiles(folderPath, "*.csv");
        foreach (string file in textFiles)
        {
            Console.WriteLine($"{count}. {Path.GetFileName(file)}");
            count ++;
        }
        Console.Write("Which file(#) would you like to select. ");
        int numberselection = int.Parse(Console.ReadLine());
        string selectedFileName = textFiles[numberselection-1];
        return selectedFileName;
    }
    static List<Goal> LoadGoals()
    {
        Console.Clear();
        List<Goal> goals = new List<Goal>();
        Console.WriteLine("What File would you like to Load?");
        string selectedFile = SelectedFileName();
        string[] lines = System.IO.File.ReadAllLines(selectedFile);
        
        foreach(string line in lines)
        {
            string[] parts = line.Split(",");
            
            if (parts[0] == "1")
            {
                goals.Add(new SimpleGoal(parts[1],parts[2],int.Parse(parts[3]),bool.Parse(parts[4])));

            }
            else if (parts[0] == "2")
            {
                goals.Add(new EternalGoal(parts[1],parts[2],int.Parse(parts[3]),bool.Parse(parts[4]),int.Parse(parts[5])));
            }
            else if (parts[0] == "3")
            {
                goals.Add(new CheckListGoal(parts[1],parts[2],int.Parse(parts[3]),bool.Parse(parts[4]),int.Parse(parts[5]),int.Parse(parts[6]),int.Parse(parts[7])));
            }

        }
        Console.Clear();
        Console.WriteLine("File Loaded Successfully");
        
        return goals;
    }
    static List<Goal> RecordEvent(List<Goal> goals)
    {
        Console.Clear();
        ListGoal(goals,false);
        Console.Write("Which goal did you complete?");
        int finishedGoal =int.Parse(Console.ReadLine());
        int count =1;

        foreach(Goal goal in goals)
        {
            if (!goal.IsCompleted())
            {
                if(finishedGoal == count)
                {
                    goal.Award();
                }
                else
                {
                    count ++;
                }
            }
        }

        return goals;
    }
    static int CalculateScore(List<Goal> goals)
    {
        int pointTotal = 0;

        foreach(Goal goal in goals)
        {
            pointTotal += goal.Score();
        }
        return pointTotal;
    }
}