using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new journal
        Journal journal = new Journal();
        bool exit = false;

        while(!exit)
        {
        // Display the options menu
        Console.WriteLine("Welcome to the Journal Program! "); 
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load the Journal from a file");
        Console.WriteLine("5. Quit");
        Console.WriteLine();
    

        // collect response
        Console.WriteLine("What would you like to do?  ");
        string choice = Console.ReadLine().ToUpper();
        Console.WriteLine();
        

            // Handle response
            switch (choice) {
                case "1":
                    // select from random prompt
                    string prompt = GetRandomPrompt();

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
                case "2":
                    // Display the Journal
                    journal.DisplayJournal();
                    Console.WriteLine();
                    break;

                case "3":
                    Console.Write("What is the filename? ");
                    string saveFile = Console.ReadLine();
                    journal.SaveJournal(saveFile);
                    Console.WriteLine("Journal saved");
                    break;
                case "4":
                     Console.Write("Enter the file name: ");
                    string loadFileName = Console.ReadLine();
                    // journal.LoadJournalFromFile(loadFileName);
                    Console.WriteLine("Journal loaded from file!");
                    Console.WriteLine();
                    break;

                case "5":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Not a valid choice. Try again");
                    break;
            } 
        }  
        
    }

    static string GetRandomPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }


}

