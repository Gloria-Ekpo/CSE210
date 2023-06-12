class ReflectingActivity : Activity
{
    private string[] ponderMessageList = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
    };

    private string[] ponderQuestionList = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
    };

    public void ReflectingLoop()
    {
        Console.WriteLine("Get ready...");
        ShowAnimation(5);

        Random random  = new Random();
        int randomNumber = random.Next(0, ponderMessageList.Length);
        string selectedPrompt = ponderMessageList[randomNumber];

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($" -- {selectedPrompt} ---");
        Console.WriteLine("When you have something in mind, press enter");


         
    }
}