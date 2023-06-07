namespace kata;

public interface IReadOnlyCharacter
{
    string Name { get; }
    int Attack { get; }
    int Defence { get; }
    IList<IItem> Equipment { get; }
}