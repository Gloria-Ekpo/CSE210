class Activity
{
    protected int activityDuration;
    protected DateTime futureTime;

    public void DisplayActivityBeginMessage(string activity, string description)
    {
        Console.WriteLine($"\nWelcome to the {activity} Activity.");
        Console.WriteLine(description);
        Console.Write("How long, in seconds, would you like your session to be? ");
        activityDuration = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayActivityEndMessage(string activity)
    {
        Console.WriteLine("\n\nWell done!");
        ShowAnimation(3);
        Console.WriteLine($"You have completed {activityDuration} seconds of the {activity}.");
        ShowAnimation(3);
    }
    
    public void ShowAnimation(int animationDuration)
    {
        string[] animationStrings = { "|", "/", "-", "\\" };

        for (int i = 0; i < animationDuration; i++)
        {
            foreach (string animationString in animationStrings)
            {
                Console.Write(animationString);
                System.Threading.Thread.Sleep(200); // Pause for 200 milliseconds
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
        }
    }
}
