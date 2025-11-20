public class EternalGoal : Goal
{
    private int _timesCompleted;

    public EternalGoal(string title, string desc, int points, bool completed, int timesCompleted): base(title, desc, points, completed)
    {
        _timesCompleted = timesCompleted;
    }

    public override void Award()
    {
        _timesCompleted ++;
    }
    public override int Score()
    {
        int score = _timesCompleted*_points;
        return score;
    }
    public override void Display()
    {
        string done = " ";
        Console.WriteLine($". [{done}] {_title} ({_desc})");

    }
    public override string ToString()
    {
        string goalString = "2,"+_title+","+_desc+","+_points+","+_completed+","+_timesCompleted;
        return goalString;    
    }
}