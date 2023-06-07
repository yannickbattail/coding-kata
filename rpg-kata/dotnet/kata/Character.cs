namespace kata;

public class Character : ICloneable, ICharacter, IReadOnlyCharacter
{
    public Character(string name, int attack, int defence)
    {
        Name = name;
        Attack = attack;
        Defence = defence;
    }

    public string Name { get; set; }
    public int Attack { get; set; }
    public int Defence { get; set; }
    public IList<IItem> Equipment { get; init; } = new List<IItem>();

    public object Clone()
    {
        return new Character(Name, Attack, Defence) { Equipment = Equipment };
    }


    public ICharacter ApplyEquipment(IReadOnlyCharacter originalCharacter)
    {
        var clonedCharacter = (ICharacter) Clone();
        foreach (var item in Equipment)
        {
            item.ApplyCharacteristic(clonedCharacter, originalCharacter);
        }

        return clonedCharacter;
    }
}