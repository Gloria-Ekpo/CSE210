using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new journal
        Journal journal = new Journal();

        // Display the options menu
        Console.WriteLine("Welcome to the Journal Program! Select from the"); 
        Console.WriteLine("following options:");
        Console.WriteLine("* [W]rite a new entry");
        Console.WriteLine("* [D]isplay your journal");
        Console.WriteLine("* [S]ave your journal to a file");
        Console.WriteLine("* [L]oad the Journal from a file");
        Console.WriteLine("* [Q]uit");
        Console.WriteLine("What would you like to do? ");
        
        // Collect response
        bool done = false;
        do {
            Console.Write("--> ");
            string response = Console.ReadLine().ToUpper();
            // Handle response
            switch (response) {
                case "W":
                    // Allow them to write a new entry
                    // Get name of journal entry
                    Console.Write("Name of entry: ");
                    string name = Console.ReadLine();
                    // get location
                    Console.Write("Where is your loacation: ");
                    string location = Console.ReadLine();
                    // get text
                    Console.Write("Enter your text: ");
                    string text = Console.ReadLine();
                    // set time
                    DateTime theCurrentTime = DateTime.Now;
                    string date = theCurrentTime.ToShortDateString();
                    // Create entry
                    Entry newEntry = new Entry(text, name, date, location);
                    // add new entry to journal
                    journal._journal.Add(newEntry);
                    
                    Console.WriteLine("Entry recorded!");
                    break;
                case "D":
                    // Display the Journal
                    break;
                case "S":
                    break;
                case "L":
                    break;
                case "Q":
                    done = true;
                    break;
                default:
                    Console.WriteLine("Not a valid input");
                    break;
            }
        } while(done == false);
    }
}