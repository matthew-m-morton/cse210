using System.Reflection.Metadata.Ecma335;
public class Menu()
{
// Attributes
    private List<Character> _party;
    private List<Character> _mob;
    private List<Character> _enemyTypeList;
    private List<Dice> _diceLog;    
// Constructor ?????
    
// Methods
    public void AddCharacter()
    {
        
    }
    public void RollInitiative(List<Character> party, List<Character> mob)
    {
        
    }
    
    public void StatMenu()
    {
        Console.Clear();
        int width = Console.WindowWidth;
        int partyWidth = (width - 3)* 3 / 5;
        int mobWidth = width - 3 - partyWidth;

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
        Console.WriteLine($"{vertical}{Space((width-6)/2)}MENU{Space((width-6)/2)}{vertical}");
        Console.WriteLine($"{teeRight}{new string(horizontal,partyWidth)}{teeDown}{new string(horizontal, mobWidth )}{teeLeft}");
        Console.WriteLine($"{vertical}{Space((partyWidth - 5) / 2)}PARTY{Space(partyWidth - 5 - (partyWidth - 5) / 2)}{vertical}{Space((mobWidth - 3) / 2)}MOB{Space(mobWidth - 3 - (mobWidth - 3)/2)}{vertical}");
        Console.WriteLine($"{teeRight}{new string(horizontal,partyWidth)}{cross}{new string(horizontal, mobWidth )}{teeLeft}");

        // Console.WriteLine($"{}");

    }

    // public List<string> Party()
    // {
        
    // }
    //     public string Partyline()
    // {
        
    // }

    public string Space(int charCount)
    {
        string space = new string(' ', charCount);
        return space;
    }
}