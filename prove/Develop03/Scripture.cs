using System.Linq;

class Scripture
{
    // Attributes
    private Reference _referenceString;
    private List<Word> _words = new List<Word>();
    // Behaviors
    public Scripture(string rawLine)
    {
        string[] parts = rawLine.Split("~~~");
        string[] words = parts[1].Split(" ");
        foreach (string word in words)
        {
            Word w = new Word(word);
            _words.Add(w);
        }

        string[] refparts = parts[0].Split(' ', ':', '-');
        string book;
        string chapter;
        string verseStart;
        string verseEnd;
        if (refparts[0].Any(char.IsDigit))
        {
            book = refparts[0] + " " + refparts[1];
            chapter = refparts[2];
            verseStart = refparts[3];
            // if (refparts.Count() == 5){ verseEnd = refparts[4]; }
            if (refparts.Count() == 5)
            {
                verseEnd = refparts[4];
                _referenceString = new Reference(book, chapter, verseStart, verseEnd);
            }
            else
            {_referenceString = new Reference(book, chapter, verseStart);}
        }
        else if (refparts[1] == "and" || refparts[1] == "of")
        {
            book = refparts[0] + " " + refparts[1] + " " + refparts[2];
            chapter = refparts[3];
            verseStart = refparts[4];
            if (refparts.Count() == 6)
            {
                verseEnd = refparts[5];
                _referenceString = new Reference(book, chapter, verseStart, verseEnd);
            }
            else {_referenceString = new Reference(book, chapter, verseStart);}
        }
        else
        {
            book = refparts[0];
            chapter = refparts[1];
            verseStart = refparts[2];
            if (refparts.Count() == 4)
            {
                verseEnd = refparts[3];
                _referenceString = new Reference(book, chapter, verseStart, verseEnd);
            }
            else {_referenceString = new Reference(book, chapter, verseStart);}
        }
    }

    public void HideWords(int numberToHide)
    {
        int hidden = 0;
        while (hidden != numberToHide)
        {
            Random randomNumber = new Random();
            int selectedWordIndex = randomNumber.Next(0, _words.Count);
            if (_words[selectedWordIndex].IsHidden() == false)
            {
                _words[selectedWordIndex].Hide();
                hidden++;
            }


        }
    }
    
    public int WordCountSeen()
    {
        int seenWords = 0;
        foreach (Word w in _words)
        {
            if (!w.IsHidden()) { seenWords++; }
        }
        return seenWords;
    }

    public void Display()
    {
        Console.Write(_referenceString.GetReference() + " ");
        foreach (Word word in _words)
        {
            word.Display();
        }
    }

    public string GetReference()
    {
        return _referenceString.GetReference();
    }
}