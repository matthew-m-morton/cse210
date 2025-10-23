
class Word
{
    // Attributes
    private string _word;
    private bool _seen;

    // Behaviors
    public Word(string word)  //Constructor
    {
        _word = word;
        _seen = true;
    }

    public void Hide()
    {
        _seen = false;
    }

    public bool IsHidden()
    {
        return !_seen;
    }

    public void Display()
    {
        if (_seen == true)
        {
            Console.Write(_word + " ");
        }
        else
        {
            int length = _word.Length;
            string underscores = "";
            for (int i = 0; i < length; i++)
            {
                underscores = underscores + '_';
            }
            Console.Write(underscores + " ");
        }
    }




}