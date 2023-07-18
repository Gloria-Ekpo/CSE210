using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Rexburg", "Idaho", 83440);
        Address address2 = new Address("456 Park Ave", "Springfield", "Illinois", 67890);

        DateTime lectureDate = DateTime.Now;
        TimeSpan lectureTime = new TimeSpan(14, 0, 0);

        Lecture lecture = new Lecture("Exploring the depths of space", "Discover the latest discoveries about distant galaxies", lectureDate, lectureTime, address1, "Dr. Astrid Nova", 100);

        Console.WriteLine("Lecture Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();

        DateTime receptionDate = DateTime.Now.AddDays(10);
        TimeSpan receptionTime = new TimeSpan(18, 30, 0);

        Reception reception = new Reception("Company Anniversary Celebration", "Join us to celebrate our anniversary", receptionDate, receptionTime, address2, "summer234@gmail.com");

        Console.WriteLine("Reception Details:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();

        DateTime outdoorGatheringDate = DateTime.Now.AddDays(14);
        TimeSpan outdoorGatheringTime = new TimeSpan(11, 0, 0);

        OutdoorGathering outdoorGathering = new OutdoorGathering("Community Picnic", "Enjoy a fun-filled picnic with friends and family", outdoorGatheringDate, outdoorGatheringTime, address1, "Sunny with a chance of clouds");

        Console.WriteLine("Outdoor Gathering Details:");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
