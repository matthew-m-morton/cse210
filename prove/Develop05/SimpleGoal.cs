public class SimpleGoal : Goal
{

    public SimpleGoal(string title, string desc, int points, bool completed): base(title, desc, points, completed)
    {
        
    }

    public override void Award()
    {
        _completed = true;
    }

    public override int Score()
    {
        if (_completed){return _points;}
        else{return 0;}
    }
    public override void Display()
    {
        string done = " ";
        if (_completed){done = "x";}
        Console.WriteLine($". [{done}] {_title} ({_desc})");
    }

    public override string ToString()
    {
        string goalString = "1,"+_title+","+_desc+","+_points+","+_completed;
        return goalString;    
    }
}