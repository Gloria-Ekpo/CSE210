using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        while (true)
        {
        Console.WriteLine("Please choose an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit the program");
        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 4)
        {
            break;
        }

        MindfulnessActivity activity = null;
        switch (choice)
        {
            case 1:
                activity = new BreathingActivity();
                break;
            case 2:
                activity = new ReflectionActivity();
                break;
            case 3:
                activity = new ListingActivity();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                continue;
        }
        

        activity.Start();
        activity.Perform();
        activity.End();
    }
}
}
    
