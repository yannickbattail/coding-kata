namespace kata;

public class Character : ICloneable
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


    public void ApplyEquipment()
    {
        foreach (var item in Equipment)
        {
            item.ApplyCharacteristic(this);
        }
    }
}