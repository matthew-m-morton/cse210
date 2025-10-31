public class MathAssignment : Assignment
{
    private string _textBookSelection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
    {
        _textBookSelection = textBookSection;
        _problems = problems;
    }

    public void GetHomeworkList()
    {
        GetSummary();
        Console.WriteLine($"Section {_textBookSelection} Problems {_problems}");
    }


}