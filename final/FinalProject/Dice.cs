public class Dice
{
// Attributes
    private int _sides;
    private int _quantity;
    private int _modifier;
    private bool _manual;

// Constructors
    public Dice(int sides, int quantity, int modifier)
    {
        _sides = sides;
        _quantity = quantity;
        _modifier = modifier;
        _manual = false;
    }   


// Methods
    public int RollDice()
    {
        // Console.Write("Would you like to roll manually? (true/false) ");
        // _manual = bool.Parse(Console.ReadLine());
        int roll;
        if (_manual)
        {
            Console.Write($"roll {_quantity}d{_sides}");
            if(_modifier > 0)
            {
                Console.Write($" and add {_modifier}");
            }
            else if(_modifier < 0)
            {
                Console.Write($" and subtract {_modifier}");
            }
            Console.Write($"\nWhat did you roll? ");
            roll = int.Parse(Console.ReadLine());
        }
        else 
        {
            Random random = new Random();
            roll = random.Next(_quantity,_quantity*_sides) + _modifier;
        }
        Console.WriteLine(roll);
        return roll;
    }
}