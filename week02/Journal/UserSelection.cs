using System;

public class UserSelection
{
    public static int GetUserSelection()
    {
        Console.WriteLine("Please select from one of the following options:");
        Console.WriteLine("1. Add to your journal");
        Console.WriteLine("2. Display what you have already written");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.Write("5. Quit: ");
        string choice = Console.ReadLine();

        return int.Parse(choice);
    }
}