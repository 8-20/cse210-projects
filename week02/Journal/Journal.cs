using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{
    private List<string> _entries = new List<string>();


    private string _filePath = "journal.txt";


    public void ShowMenu()
    {
        Console.Write("What is the name of your journal? ");
        _filePath = Console.ReadLine();
        _filePath = "../../../" + _filePath + ".txt";


        bool keepRunning = true;
        while (keepRunning)
        {
            UserSelection userSelection = new UserSelection();
            int selection = UserSelection.GetUserSelection();

            switch (selection)
            {
                case 1:
                    AddEntry();
                    break;
                case 2:
                    DisplayEntries();
                    break;
                case 3:
                    SaveToFile();
                    break;
                case 4:
                    LoadFromFile();
                    break;
                case 5:
                    keepRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private void AddEntry()
    {
        PromptGenerator prompt = new PromptGenerator();
        string randomPrompt = prompt.GetRandomPrompt();
        Console.WriteLine($"Here's a thought starter: {randomPrompt}");
        Console.Write(">");

        //Console.WriteLine("You chose to add to your journal.");
        string dailyEntry = Console.ReadLine();
        Console.Write("Would you like to add anything more? (y/n): ");
        if (Console.ReadLine().ToLower() == "y")

        {
            Console.Write("Enter additional thoughts: ");
            dailyEntry += " Plus: " + Console.ReadLine();
        }
        //Console.WriteLine($"You wrote: {dailyEntry}");

        // Display the entries in the list.
        DateTime currentTime = DateTime.Now;
        Entry e = new Entry();
        e._date = currentTime.ToString();
        e._promptText = randomPrompt;
        e._entryText = dailyEntry;

        //List<Entry> entries = new List<Entry>();
        //entries.Add(e);
        string fullEntry = e._date + " - " + e._promptText + " - " + e._entryText;
        _entries.Add(fullEntry);
    }


    private void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.");
        }
        else
        {
            Console.WriteLine("\n--- Journal Entries ---");
            foreach (var entry in _entries)
            {
                Console.WriteLine(entry);
            }
            Console.WriteLine("---------------------");
        }
    }

    private void SaveToFile()
    {
        string modifiedFilePath = _filePath.Substring(9);
        var di = new DirectoryInfo(Directory.GetCurrentDirectory());
        string parent3 = di.Parent.Parent.Parent.FullName;
        string yourdirectory = parent3 + "\\" + modifiedFilePath;
        Console.WriteLine($"Your file was stored at {yourdirectory}\n");

        try
        {
            File.WriteAllLines(_filePath, _entries);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}");
        }
    }

    private void LoadFromFile()
    {
        if (File.Exists(_filePath))
        {
            try
            {
                _entries = new List<string>(File.ReadAllLines(_filePath));
                string modfiedFilePath = _filePath.Substring(9);
                Console.WriteLine($"{modfiedFilePath} loaded.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading file: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Journal file not found. Starting with an empty journal.");
        }
    }
}