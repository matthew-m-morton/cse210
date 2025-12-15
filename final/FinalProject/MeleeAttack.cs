public class MeleeAttack : Attack
{
// Attributes


// Constructor
    public MeleeAttack(string name, string damage) : base(name, damage)
    {
        
    }
// Methods
    public override string Display()
    {
        string displayString = $"{_name} {_damage} ";
        return displayString;
    }

    public override string ToString()
    {
        string attackString = "Melee"+"~~"+_name+"~~"+_damage;

        return attackString;
    }
    
}