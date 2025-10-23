class Reference
{
    // Attributes
    private string _book;
    private string _chapter;
    private string _verseStart;
    private string _verseEnd;
    
    // Behaviors
    
    public Reference(string b, string c, string vs, string ve)
    {
        _book = b;
        _chapter = c;
        _verseStart = vs;
        _verseEnd = ve;
    }
    public Reference(string b, string c, string vs)
    {
        _book = b;
        _chapter = c;
        _verseStart = vs;
        _verseEnd = "single";
    }    
    public string GetReference()
    {
        string reference = "";
        if (_verseEnd == "single")
        {
            reference = $"{_book} {_chapter}:{_verseStart}";
        }
        else
        {
            reference = $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";            
        }
        return reference;
    }

}