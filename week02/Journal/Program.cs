using System;
using System.Collections.Generic;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        // 1. Create an instance of the ItemListManager class.
        PromptGenerator prompt = new PromptGenerator();

        // 2. Call the method to get a random item.
        string randomPrompt = prompt.GetRandomPrompt();

        // 3. Display the result.
        Console.WriteLine($"To get started, try reflecting on this question: {randomPrompt}");

        UserSelection userSelection = new UserSelection();  
        int selection = UserSelection.GetUserSelection();
        //Console.WriteLine($"You selected option {selection}.");

        switch (selection)
        {
            case 1:
                Console.WriteLine("You chose to add to your journal.");
                Console.WriteLine($"To get started, try reflecting on this question: {randomPrompt}");
                string dailyEntry = Console.ReadLine();
                Console.WriteLine($"You wrote: {dailyEntry}");
                Console.Write("Save it? (y/n): ");
                string saveChoice = Console.ReadLine();
                if (saveChoice.ToLower() == "y")
                {
                    Console.WriteLine("Your entry has been saved.");
                }
                else
                {
                    Console.WriteLine("Your entry was not saved.");
                }

                break;
            case 2:
                Console.WriteLine("You chose to display what you have already written.");
                break;
            case 3:
                Console.WriteLine("You chose to load.");
                break;
            case 4:
                Console.WriteLine("You chose to save.");
                break;
            case 5:
                Console.WriteLine("You chose to quit.");
                break;
            default:
                Console.WriteLine("Invalid selection. Please choose a number between 1 and 5.");
                break;
        }

        

        
    }
}