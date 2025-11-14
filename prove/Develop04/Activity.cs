public class Activity
{
    protected string _title;
    protected string _desc;
    protected int _duration;

    public Activity(string aTitle, string aDesc)
    {
        _title = aTitle;
        _desc = aDesc;
        _duration = 0;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void InteractPrologue()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_title} Activity");
        Console.WriteLine();
        Console.WriteLine(_desc);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        Console.WriteLine();
    }
    
    public void InteractEpilogue()
    {
        Console.WriteLine("Well Done!!");
        Timer.PauseWithAnimation(2);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of {_title} Activity.");
        Timer.PauseWithAnimation(6);
    }


}