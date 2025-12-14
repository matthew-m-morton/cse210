public abstract class Attack
{
// Attributes
    protected string _name;
    protected string _damage;


// Constructor
    public Attack(string name,string damage)
    {
        _name = name;
        _damage = damage;
    }

// Methods
    public abstract string Display();


    public abstract override string ToString();

    
}