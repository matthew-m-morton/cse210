using System.Diagnostics.Metrics;
using System.Formats.Asn1;

public class Menu
{
// Attributes
    private List<PlayerCharacter> _party = new List<PlayerCharacter>();
    private List<EnemyCharacter> _mob = new List<EnemyCharacter>(); 
    private List<string> _partystrings = new List<string>();
    private List<string> _mobstrings = new List<string>();
    private List<string> _partystringschunked = new List<string>();
    private List<string> _mobstringschunked = new List<string>();



// Constructor ?????

    public Menu(List<Character> characters) 
    {
        _party = characters.OfType<PlayerCharacter>().ToList();
        _mob = characters.OfType<EnemyCharacter>().ToList();
        foreach(Character partychar in _party)
        { 
            _partystrings.AddRange(partychar.Display());
        }
        foreach(Character mobchar in _mob)
        {
            _mobstrings.AddRange(mobchar.Display());
        }
    }

// Methods

    public void RollInitiative()
    {
        List<(string, int)> initChar = new List<(string,int)>();
        foreach(Character character in _party)
        {
            initChar.Add(character.RollInit());
        }
                foreach(Character character in _mob)
        {
             initChar.Add(character.RollInit());           
        }
        StatMenu();

        // reorder initChar
        initChar = initChar.OrderByDescending(pair => pair.Item2).ToList();
        
        foreach((string,int) pair in initChar)
        {
            Console.WriteLine($"{pair.Item2} {pair.Item1}");
            // counter++;
        }
        Console.Read();

    }
    
    public void StatMenu()
    {
        Console.Clear();
        int width = Console.WindowWidth;
        int partyWidth = (width - 3)* 3 / 5;
        int mobWidth = width - 3 - partyWidth;

        // chunk lists fo strings to fit in the menu.
        _partystringschunked = ChunkStrings(_partystrings,partyWidth);
        _mobstringschunked = ChunkStrings(_mobstrings,mobWidth);

        // equalized lists
        while(_partystringschunked.Count() > _mobstringschunked.Count())
        {
            _mobstringschunked.Add(Space(mobWidth));
        }
        while(_partystringschunked.Count() < _mobstringschunked.Count())
        {
            _partystringschunked.Add(Space(partyWidth));
        }


        // Box-drawing characters
        char topLeft = '┌';
        char topRight = '┐';
        char bottomLeft = '└';
        char bottomRight = '┘';
        char horizontal = '─';
        char vertical = '│';
        char cross = '┼';
        char teeDown = '┬';
        char teeUp = '┴';
        char teeRight = '├';
        char teeLeft = '┤';

        // Menu Header
        Console.WriteLine($"{topLeft}{new string(horizontal, width -2 )}{topRight}");
        Console.WriteLine($"{vertical}{Space((width-6)/2)}MENU{Space(width-6 - ((width-6)/2))}{vertical}");
        Console.WriteLine($"{teeRight}{new string(horizontal,partyWidth)}{teeDown}{new string(horizontal, mobWidth )}{teeLeft}");
        Console.WriteLine($"{vertical}{Space((partyWidth - 5) / 2)}PARTY{Space(partyWidth - 5 - (partyWidth - 5) / 2)}{vertical}{Space((mobWidth - 3) / 2)}MOB{Space(mobWidth - 3 - (mobWidth - 3)/2)}{vertical}");
        Console.WriteLine($"{teeRight}{new string(horizontal,partyWidth)}{cross}{new string(horizontal, mobWidth )}{teeLeft}");
        
        // iterate through string chunks.
        for (int i = 0; i <+ _partystringschunked.Count(); i++)
        {
            Console.WriteLine($"{vertical}{_partystringschunked[i]}{vertical}{_mobstringschunked[i]}{vertical}");
        }

        // bottom end.
        Console.WriteLine($"{bottomLeft}{new string(horizontal,partyWidth)}{teeUp}{new string(horizontal, mobWidth )}{bottomRight}");

    }

    // public List<string> Party()
    // {
        
    // }


    public string Space(int charCount)
    {
        string space = new string(' ', charCount);
        return space;
    }

public List<string> ChunkStrings(List<string> strings, int maxLength)
// function from claude AI fixed and adapted by me.
{
    List<string> result = new List<string>();
    string current = " ";
    int counter = 1 ;
    foreach (string str in strings)
    {
        if (current == " ")
            {
                current = $"{counter} ";
                counter ++;
            }
        else if(str == " ")
            {
                current += Space(maxLength - current.Length);
                result.Add(current);
                current = "";
            }
        else if (current.Length + str.Length > maxLength)
            {
                // Pad current to maxLength and add to result
                current += Space(maxLength - current.Length);
                result.Add(current);
                current = "";
            }
        
        current += str;
    }
    
    // Don't forget the last chunk (pad it too)
    if (current.Length > 0)
    {
        current += Space(maxLength - current.Length);
        result.Add(current);
    }
    
    return result;
}
}