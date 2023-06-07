namespace kata;

public interface ICharacter
{
    string Name { get; set; }
    int Attack { get; set; }
    int Defence { get; set; }
    IList<IItem> Equipment { get; }
}