namespace kata;

public interface IItem
{
    public string Name { get; set; }
    Character ApplyCharacteristic(Character character);
}