using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running run1 = new Running(new DateTime(2022, 11, 3), 30, 3);
        activities.Add(run1);

        Cycling cycle1 = new Cycling(new DateTime(2022, 11, 4), 45, 15);
        activities.Add(cycle1);

        Swimming swim1 = new Swimming(new DateTime(2022, 11, 5), 20, 10);
        activities.Add(swim1);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}
