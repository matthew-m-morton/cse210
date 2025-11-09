public class Activity
{
    private string _title;
    private string _desc;
    private int _duration;

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
        Console.WriteLine($"Welcome to the {_title} Activity");
        Console.WriteLine();
        Console.WriteLine(_desc);
    }
    
    public void InteractEpilogue()
    {
        Console.WriteLine("Well Done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of {_title} Activity.");
    }


}