public abstract class Attack
{
// Attributes
    protected string _name;
    protected int _damage;
    private List<string> _damageTypes;
    protected List<string> _properties;

// Constructor
    public Attack()
    {
        
    }

// Methods
    public abstract void Display();
    public abstract void DisplayDetailed();

    
}