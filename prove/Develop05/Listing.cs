class ListingActivity : Activity
{
    private string[] promptList = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void PerformListingActivity()
    {
        Console.WriteLine("Get ready..."); // Display a message to get ready for the activity
        Thread.Sleep(3000); // Pause for 3 seconds

        Random random = new Random(); // Create a random number generator
        int randomNumber = random.Next(0, promptList.Length); // Generate a random number to select a prompt from the list
        string selectedPrompt = promptList[randomNumber]; // Retrieve the selected prompt from the list

        Console.WriteLine("List as many responses as you can to the following prompt:"); // Prompt the user to list responses
        Console.WriteLine($" --- {selectedPrompt} ---"); // Display the selected prompt
        Console.Write("You may begin in: "); // Prompt the user to begin listing
        for (int i = 5; i > 0; i--) // Count from 5 to 1
        {
            Console.Write($"\b \b{i}"); // Display the countdown number and erase it quickly
            Thread.Sleep(1000); // Pause for 1 second
        }
    }
}
