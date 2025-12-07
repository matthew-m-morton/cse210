public abstract class Character
{
// Attributes
    protected int _hp;
    protected int _hpMax;
    protected int _armorClass;
    protected int[] _abilityScores;
    protected List<string> _resists;
    protected List<string> _weakTos;
    protected List<Attack> _attacks;
    protected List<string> _languages;

    protected int _speed;


// Constructors
    public Character()
    {
        
    }
    public Character(int hp, int hpMax, int armorClass, int[] abilityScores, List<string> resists, List<string> weakTos, List<Attack> attacks, List<string> languages, int speed)
    {
        
    }

// Methods
    public abstract void Heal();
    public abstract void Damage();
    public abstract void RollInit();
    public abstract void Display();
    public abstract void DisplayAttacks();
    public abstract void DisplayDetail();
    public abstract void ToString();

    
}