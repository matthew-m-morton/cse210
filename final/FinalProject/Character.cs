public abstract class Character
{
// Attributes
    protected string _name;
    protected int _hp;
    protected int _hpMax;
    protected int _armorClass;
    protected int[] _abilityScores;
    protected List<Attack> _attacks;
    protected int _speed;


// Constructors
    public Character()
    {
        
    }
    public Character(string name, int hp, int hpMax, int armorClass, int[] abilityScores,  List<Attack> attacks, int speed)
    {
        _name = name;
        _hp = hp;
        _hpMax = hpMax;
        _armorClass = armorClass;
        _abilityScores = abilityScores;
        _attacks = attacks;
        _speed = speed;
    }

// Methods
    // public abstract void Heal();
    // public abstract void Damage();
    public (string, int) RollInit()
    {
        int dexMod = (_abilityScores[1] - 10) / 2;
        Dice roll = new Dice(20,1,dexMod);
        (string,int) initiative = (_name,roll.RollDice());
        return initiative;
    }
    public abstract List<string> Display();
    public  List<string> DisplayAttacks()
    {
        List<string> attackDisplayStrings = new List<string>{};
        foreach(Attack attack in _attacks)
        {
            attackDisplayStrings.Add(attack.Display());
        } 
        return attackDisplayStrings;
    }
    public abstract void DisplayDetail();
    public abstract override string ToString();

    
}