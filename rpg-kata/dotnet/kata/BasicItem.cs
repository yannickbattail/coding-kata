namespace kata;

public class BasicItem : IItem
{
    public BasicItem(string name, int attack, int defence)
    {
        Name = name;
        Attack = attack;
        Defence = defence;
    }

    public int Attack { get; set; }
    public int Defence { get; set; }
    public string Name { get; set; }

    public Character ApplyCharacteristic(Character character)
    {
        character.Attack += Attack;
        character.Defence += Defence;
        return character;
    }
}