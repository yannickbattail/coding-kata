using FluentAssertions;
using Xunit;

namespace kata;

public class Tests
{
    [Fact]
    private void Test()
    {
        var gandalf = new Character("Gandalf", 10, 10)
        {
            Equipment = new List<IItem>
            {
                new BasicItem("sword", 5, 0),
                new BasicItem("shield", -1, 3)
            }
        };
        Rpg.Print(gandalf);
        gandalf.ApplyEquipment();
        Rpg.Print(gandalf);

        gandalf.Attack.Should().Be(14);
        gandalf.Defence.Should().Be(13);
    }
}