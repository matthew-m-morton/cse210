public class PlayerCharacter : Character
{
// Attributes
    private int _level;
    private string _charClass;
    private int[] _spellSlots;
    private bool[] _proficiencies;

// Constructor
        public PlayerCharacter(string name, int hp, int hpMax, int armorClass, int[] abilityScores, List<Attack> attacks, int speed,
        int level, string charClass, int[] spellSlots, bool[] proficiencies) : base (name, hp, hpMax, armorClass, abilityScores, attacks, speed)
    {
        _level = level;
        _charClass = charClass;
        _spellSlots = spellSlots;
        _proficiencies = proficiencies;
    }

// Methods
    public override void Heal(){

    }
    public override void Damage(){

    }

    public override List<string> Display(){
                string health = $"{_hp}/{_hpMax}";
        string strScores = $"STR: {_abilityScores[0]}";
        string dexScores = $"DEX: {_abilityScores[1]}";
        string conScores = $"CON: {_abilityScores[2]}";
        string intScores = $"INT: {_abilityScores[3]}";
        string wisScores = $"WIS: {_abilityScores[4]}";
        string chaScores = $"CHA: {_abilityScores[5]}";

        List<string> strings = new List<string> {_name, health, strScores, dexScores, conScores, intScores, wisScores, chaScores };
        return strings;
    }

    public override void DisplayDetail(){

    }
    public override string ToString(){
        string charString = "Player"+"~~"+_name+"~~"+_hp+"~~"+_hpMax+"~~"+_armorClass+"~~"+_abilityScores+"~~"
        +_attacks+"~~"+_speed+"~~"+_level+"~~"+_charClass+"~~"+_spellSlots+"~~"+_proficiencies;
        return charString;

    }

    
}