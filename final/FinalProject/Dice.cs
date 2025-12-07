public class Dice
{
// Attributes
    private int _sides;
    private int _quantity;
    private int _modifier;
    private bool _manual;

// Constructors
    public Dice(int sides, int quantity, int modifier, bool manual)
    {
        _sides = sides;
        _quantity = quantity;
        _modifier = modifier;
        _manual = manual;
    }   

// Methods
    public int RollDice()
    {
        int roll;
        if (_manual)
        {
            Console.Write($"roll {_quantity}d{_sides}");
            if(_modifier > 0)
            {
                Console.WriteLine($" and add {_modifier}");
            }
            else if(_modifier < 0)
            {
                Console.WriteLine($" and subtract {_modifier}");
            }
            Console.WriteLine("What did you roll?");
            roll = int.Parse(Console.ReadLine());
        }
        else 
        {
            Random random = new Random();
            roll = random.Next(_quantity,_quantity*_sides) + _modifier;
        }
        return roll;
    }
}