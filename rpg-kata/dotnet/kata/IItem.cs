namespace kata;

public interface IItem
{
    public string Name { get; set; }
    void ApplyCharacteristic(ICharacter character, IReadOnlyCharacter originalCharacter);
}