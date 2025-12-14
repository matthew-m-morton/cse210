using System.Reflection.Metadata.Ecma335;
Console.OutputEncoding = System.Text.Encoding.UTF8;
public class Menu
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
    
    public void BuildMenu()
    {
        Console.Clear();
        // Box-drawing characters
        char topLeft = '┌';
        char topRight = '┐';
        // char bottomLeft = '└';
        // char bottomRight = '┘';
        char horizontal = '─';
        // char vertical = '│';
        // char cross = '┼';
        // char teeDown = '┬';
        // char teeUp = '┴';
        // char teeRight = '├';
        // char teeLeft = '┤';

        // Example usage
        Console.WriteLine($"{topLeft}{new string(horizontal, Console.WindowWidth -2 )}{topRight}");
        }
}