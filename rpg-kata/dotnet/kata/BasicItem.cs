namespace kata;

public class BasicItem : IItem
{
    public BasicItem(string name)
    {
        Name = name;
    }

    public int Attack { get; set; }
    public int Defence { get; set; }
    public string Name { get; set; }

    public void ApplyCharacteristic(ICharacter character, IReadOnlyCharacter originalCharacter)
    {
        character.Attack += Attack;
        character.Defence += Defence;
    }
}