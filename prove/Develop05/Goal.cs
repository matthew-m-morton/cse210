public abstract class Goal
{
    protected string _title;
    protected string _desc;
    protected int _points;
    protected bool _completed;

    public Goal(string title, string desc, int points, bool completed)
    {
        _title = title;
        _desc = desc;
        _points = points;
        _completed = completed;
    }


    public abstract void Award();

    public abstract int Score();
    public abstract void Display();
    public bool IsCompleted()
    {
        return _completed;
    }
    
}