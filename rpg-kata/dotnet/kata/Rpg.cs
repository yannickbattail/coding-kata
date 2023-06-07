namespace kata;

public static class Rpg
{
    public static void Print(Character character)
    {
        Console.WriteLine("BasicItem: " + character.Name);
        PrintCharacteristicWithName("Attack", character.Attack);
        PrintCharacteristicWithName("Defence", character.Defence);
        Console.WriteLine("Equipment: [");
        foreach (var item in character.Equipment)
        {
            Print(item);
        }

        Console.WriteLine("]");
    }

    private static void Print(IItem item)
    {
        switch (item)
        {
            case BasicItem basicItem:
                Console.WriteLine("BasicItem: " + basicItem.Name);
                PrintCharacteristicWithName("Attack", basicItem.Attack);
                PrintCharacteristicWithName("Defence", basicItem.Defence);
                Console.WriteLine();
                break;
            case PercentItem percentItem:
                Console.WriteLine("BasicItem: " + percentItem.Name);
                PrintCharacteristicPercentWithName("Attack", percentItem.Attack);
                PrintCharacteristicPercentWithName("Defence", percentItem.Defence);
                Console.WriteLine();
                break;
        }
    }

    private static void PrintCharacteristicWithName(string characteristicName, int characteristicValue)
    {
        Console.Write(characteristicName + ": ");
        PrintCharacteristic(characteristicValue);
        Console.WriteLine();
    }

    public static void PrintCharacteristicPercentWithName(string characteristicName, int characteristicValue)
    {
        Console.Write(characteristicName + ": ");
        PrintCharacteristic(characteristicValue);
        Console.WriteLine("%");
    }

    private static void PrintCharacteristic(int characteristic)
    {
        switch (characteristic)
        {
            case < 0:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(characteristic);
                Console.ResetColor();
                break;
            case > 0:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("+" + characteristic);
                Console.ResetColor();
                break;
            default:
                Console.Write(characteristic);
                break;
        }
    }
}