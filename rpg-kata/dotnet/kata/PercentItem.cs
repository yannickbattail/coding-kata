namespace kata;

public class PercentItem : IItem
{
    public PercentItem(string name)
    {
        Name = name;
    }

    public int Attack { get; set; }
    public int Defence { get; set; }
    public string Name { get; set; }

    public void ApplyCharacteristic(ICharacter character, IReadOnlyCharacter originalCharacter)
    {
        character.Attack += (int)Math.Round(Attack / 100d * originalCharacter.Attack);
        character.Defence += (int)Math.Round(Defence / 100d * originalCharacter.Defence);
    }
}