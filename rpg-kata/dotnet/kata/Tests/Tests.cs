using FluentAssertions;
using Xunit;

namespace kata.Tests;

public class Tests
{
    [Fact]
    private void Test_BasicItem_1()
    {
        // un personnage avec 10 points en attaque et 10 points en défense qui possède dans son équipement une épée +2 en attaque aura 12 points en attaque et 10 points en défense
        var gandalf = new Character("Gandalf", 10, 10)
        {
            Equipment = new List<IItem>
            {
                new BasicItem("épée") {Attack = +2},
            }
        };
        Rpg.Print(gandalf);
        var actual = gandalf.ApplyEquipment(gandalf);
        Rpg.Print(gandalf);

        actual.Attack.Should().Be(12);
        actual.Defence.Should().Be(10);
    }
    
    [Fact]
    private void Test_BasicItem_2()
    {
        // un personnage avec 10 points en attaque et 10 points en défense avec un bouclier -1 en attaque et +5 en défense aura 9 en attaque et 15 en défense
        var gandalf = new Character("Gandalf", 10, 10)
        {
            Equipment = new List<IItem>
            {
                new BasicItem("bouclier") {Attack = -1, Defence = +5},
            }
        };
        Rpg.Print(gandalf);
        var actual = gandalf.ApplyEquipment(gandalf);
        Rpg.Print(gandalf);

        actual.Attack.Should().Be(9);
        actual.Defence.Should().Be(15);
    }
    
    [Fact]
    private void Test_BasicItem_3()
    {
        // un personnage avec 10 points en attaque et 10 points en défense avec un arc +3 en attaque et une armure +7 en défense aura 13 en attaque et 17 en défense
        var gandalf = new Character("Gandalf", 10, 10)
        {
            Equipment = new List<IItem>
            {
                new BasicItem("arc") {Attack = +3},
                new BasicItem("armure") {Defence = +7},
            }
        };
        Rpg.Print(gandalf);
        var actual = gandalf.ApplyEquipment(gandalf);
        Rpg.Print(gandalf);

        actual.Attack.Should().Be(13);
        actual.Defence.Should().Be(17);
    }    
    
    [Fact]
    private void Test_PercentItem_1()
    {
        // un personnage avec 10 points en attaque et 10 points en défense avec une cape +20% en défense aura 12 points en défense
        var gandalf = new Character("Gandalf", 10, 10)
        {
            Equipment = new List<IItem>
            {
                new PercentItem("cape") {Defence = +20},
            }
        };
        Rpg.Print(gandalf);
        var actual = gandalf.ApplyEquipment(gandalf);
        Rpg.Print(gandalf);

        actual.Attack.Should().Be(10);
        actual.Defence.Should().Be(12);
    }
    
    [Fact]
    private void Test_PercentItem_2()
    {
        // un personnage avec 10 points en attaque et 10 points en défense avec une cape +20% en défense et un casque +50% en défense aura 17 points en défense
        var gandalf = new Character("Gandalf", 10, 10)
        {
            Equipment = new List<IItem>
            {
                new PercentItem("cape") {Defence = +20},
                new PercentItem("casque") {Defence = +50},
            }
        };
        Rpg.Print(gandalf);
        var actual = gandalf.ApplyEquipment(gandalf);
        Rpg.Print(gandalf);

        actual.Attack.Should().Be(10);
        actual.Defence.Should().Be(17);
    }
   
    [Fact]
    private void Test_PercentItem_3()
    {
        // un personnage avec 18 points en attaque avec une dague +40% en attaque aura 25 points en attaque (arrondi)
        var gandalf = new Character("Gandalf", 18, 10)
        {
            Equipment = new List<IItem>
            {
                new PercentItem("dague") {Attack = +40},
            }
        };
        Rpg.Print(gandalf);
        var actual = gandalf.ApplyEquipment(gandalf);
        Rpg.Print(gandalf);

        actual.Attack.Should().Be(25);
        actual.Defence.Should().Be(10);
    }

}