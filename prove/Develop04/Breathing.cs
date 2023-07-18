public class BreathingActivity : MindfulnessActivity
    {
        public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {
        }

        public override void Perform()
        {
            int timeElapsed = 0;
            while (timeElapsed < Duration)
            {
                Console.WriteLine("Breathe in...");
                ShowAnimation(3);
                timeElapsed += 3;
                if (timeElapsed >= Duration) break;

                Console.WriteLine("Breathe out...");
                ShowAnimation(3);
                timeElapsed += 3;
            }
        }
    }