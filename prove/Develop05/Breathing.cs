class BreathingActivity : Activity
{
    public void PerformBreathingActivity()
    {
        Console.WriteLine("Get ready...");
        ShowAnimation(5); // Show a visual animation for 5 seconds

        futureTime = DateTime.Now.AddSeconds(activityDuration); // Calculate the future time when the activity should end
        while (DateTime.Now < futureTime) // Keep looping until the current time reaches the future time
        {
            Console.Write("Breathe in... "); // Prompt the user to breathe in
            for (int i = 5; i > 0; i--) // Count from 5 to 1
            {
                Console.Write($"\b \b{i}"); // Display the countdown number and erase it quickly
                Thread.Sleep(1000); // Pause for 1 second
            }
            Console.WriteLine("\b \b"); // Clear the countdown number

            Console.Write("Breathe out... "); // Prompt the user to breathe out
            for (int i = 5; i > 0; i--) // Count from 5 to 1
            {
                Console.Write($"\b \b{i}"); // Display the countdown number and erase it quickly
                Thread.Sleep(1000); // Pause for 1 second
            }
        }
    }
}
