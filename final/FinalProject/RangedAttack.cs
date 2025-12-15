public class RangedAttack : Attack
{
// Attributes
    private int _normalRange;
    private int _maxRange;
// Constructor
    public RangedAttack(string name, string damage, int normalRange, int maxRange) : base(name, damage)
    {
        _normalRange = normalRange;
        _maxRange = maxRange;
    }

// Methods
    public override string Display()
    {
        string displayString = $"{_name} {_damage} {_normalRange}/{_maxRange} ";
        return displayString;
    }

    public override string ToString()
    {
        string attackString = "Ranged"+"~~"+_name+"~~"+_damage+"~~"+_normalRange+"~~"+_maxRange;

        return attackString;
    }
}