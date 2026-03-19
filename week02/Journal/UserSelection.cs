using System;

public class UserSelection
{
    public static int GetUserSelection()
    {
        Console.WriteLine("Please select from one of the following options:");
        Console.WriteLine("1. Add an entry to your journal");
        Console.WriteLine("2. Display what you have already entered");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.Write("5. Quit: ");
        string choice = Console.ReadLine();

        return int.Parse(choice);
    }
}