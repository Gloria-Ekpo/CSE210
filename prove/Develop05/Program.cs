using System;

class Program
{
    static void Main(string[] args)
    {
        int menuOptions = 0;

        while (menuOptions !=4)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity ");
            Console.WriteLine("2. Start reflecting activity ");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            menuOptions = Convert.ToInt16(Console.ReadLine());

            if (menuOptions == 1){
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.DisplayActivityBeginMessage("Breathing", "This activity will help you relax by walking through breathing in and out slowly.");
            
                Console.WriteLine("Welcome to the Breathing Activity.");
                Console.WriteLine("Clear your mind and focus on your breathing.");

                Console.Write("How long, in seconds, would you like for your session? ");
                
            }
        }

    }
}