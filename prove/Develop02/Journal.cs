using System.ComponentModel.DataAnnotations;

public class Journal
{


    public List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        for (int i = 0; i < _entries.Count(); i++)
        {
            _entries[i].Display();
        }
    }

    public Entry WriteEntry()
    {
        Prompt p1 = new Prompt();

        Entry e1 = new Entry();
        e1._prompt = p1.GeneratePrompt();
        e1._date = DateTime.Now.ToString("MM/dd/yyyy");

        Console.WriteLine($"Date: {e1._date} - Prompt: {e1._prompt}");
        e1._response = Console.ReadLine();
        return e1;
    }
}