using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    // Save function.
    public static void SaveToFile(string dailyEntry)
    {
        string filename = "../../../daily-journal.txt";

        if (File.Exists(filename) && filename.Length > 0)
        {
            using (StreamWriter outputFile = File.AppendText(filename))
            {
                outputFile.WriteLine(dailyEntry);
            } 
        }
        else
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(dailyEntry);
            }
        }

       
    }
    static void Main(string[] args)
    {
       
        UserSelection userSelection = new UserSelection();
        int selection = UserSelection.GetUserSelection();
       // Console.WriteLine($"You selected option {selection}."); 

        // Obtain a random prompt.
        PromptGenerator _prompt = new PromptGenerator();
        string randomPrompt = _prompt.GetRandomPrompt();
        // 3. Display the result.
       // Console.WriteLine($"To get started, try reflecting on this question: {randomPrompt}");


        switch (selection)
        {
            case 1:
                //Console.WriteLine("You chose to add to your journal.");
                Console.WriteLine($"As you add to your journal , reflect on this question: {randomPrompt}");
                Console.Write("Enter your thoughts: ");
                string dailyEntry = Console.ReadLine();
                Console.Write("Would you like to add anything more? (y/n): ");
                if (Console.ReadLine().ToLower() == "y")
                
                {
                    Console.Write("Enter additional thoughts: ");
                    dailyEntry += " " + Console.ReadLine();
                }   
               // Console.WriteLine($"You wrote: {dailyEntry}");

                // Display the entries in the list.
                DateTime currentTime = DateTime.Now;
                Entry e = new Entry();
                e._date = currentTime.ToString();
                e._promptText = randomPrompt;
                e._entryText = dailyEntry;

                List<Entry> entries = new List<Entry>();
                entries.Add(e);
                string fullEntry = e._date + " - " + e._promptText + " - " + e._entryText;


               /* foreach (Entry entry in entries)
                {
                    Console.WriteLine($"Date: {entry._date}");
                    Console.WriteLine($"Prompt: {entry._promptText}");
                    Console.WriteLine($"Entry: {entry._entryText}");

                }*/

                Console.Write("Good job!Save it? (y/n): ");
                string saveChoice = Console.ReadLine();
               
                if (saveChoice.ToLower() == "y")
                {
                    SaveToFile(fullEntry);
                    Console.WriteLine("Your entry has been saved.");
                }
                else
                {
                    Console.WriteLine("Your entry was not saved.");
                }

                break;
            case 2:
                //Console.WriteLine("You chose to display what you have already written.");
                break;
            case 3:
                //Console.WriteLine("You chose to load.");
                break;
            case 4:
               // Console.WriteLine("You chose to save.");
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
