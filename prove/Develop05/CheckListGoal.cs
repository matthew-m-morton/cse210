public class CheckListGoal : Goal
{
    private int _timesCompleted;
    private int _bonusThreshold;
    private int _bonusPoints;

    public CheckListGoal(string title, string desc, int points, bool completed, int timesCompleted, int bonusThreshold, int bonusPoints): base(title,desc,points,completed)
    {
        _timesCompleted = timesCompleted;
        _bonusThreshold = bonusThreshold;
        _bonusPoints = bonusPoints;    
    }



    public override void Award()
    {
        _timesCompleted ++;
        if (_timesCompleted == _bonusThreshold){_completed = true;}
    }

    public override int Score()
    {
        int score = _points * _timesCompleted;
        if(_timesCompleted == _bonusThreshold)
        {
            score += _bonusPoints;
        }
        return score;
    }
    public override void Display()
    {
        string done = " ";
        if (_completed){done = "x";}
        Console.WriteLine($". [{done}] {_title} ({_desc}) -- Currently completed: {_timesCompleted}/{_bonusThreshold}");
 
    }
    public override string ToString()
    {
        string goalString = "3,"+_title+","+_desc+","+_points+","+_completed+","+_timesCompleted+","+_bonusThreshold+","+_bonusPoints;
        return goalString;
    }    
}