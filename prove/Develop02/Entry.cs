public class Entry
{
    public string _response;
    public string _prompt;
    public string _date;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_response}\n");


    }
}