public class ListingActivity : MindfulnessActivity
    {
        private string[] prompts = new string[]
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        private Random random = new Random();

        public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
        }

        public override void Perform()
        {
            int promptIndex = random.Next(prompts.Length);
            Console.WriteLine(prompts[promptIndex]);

            Console.WriteLine("You have several seconds to think about the prompt.");
            ShowAnimation(3);

            Console.WriteLine("Please start listing items:");
            int timeElapsed = 0;
            int itemCount = 0;
            while (timeElapsed < Duration)
            {
                string item = Console.ReadLine();
                itemCount++;
                timeElapsed += 3;
            }

            Console.WriteLine($"You have listed {itemCount} items.");
        }
    }