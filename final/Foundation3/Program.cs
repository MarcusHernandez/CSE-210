using System;

class Program
{
    static void Main()
    {
        Address lectureAddress = new Address("123 Main St", "Idaho", "ID", "USA");
        Address receptionAddress = new Address("17th Steet", "Los Angeles", "CA", "USA");
        Address gatheringAddress = new Address("Sunnyside", "Salt lake City", "UT", "USA");

        Lecture lectureEvent = new Lecture("Tech Talk", "An informative tech talk on Programming", DateTime.Parse("2023-07-25"), TimeSpan.Parse("14:00"), lectureAddress, "John Doe", 100);
        Reception receptionEvent = new Reception("Networking Night", "An evening of networking and socializing", DateTime.Parse("2023-08-10"), TimeSpan.Parse("18:30"), receptionAddress, "rsvp@Gmail.com");
        OutdoorGathering gatheringEvent = new OutdoorGathering("Picnic at the Zoo", "A fun picnic at the Zoo", DateTime.Parse("2023-09-05"), TimeSpan.Parse("12:00"), gatheringAddress, "Sunny with a high of 80°F");

        Console.WriteLine("Standard Details:");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine(gatheringEvent.GetStandardDetails());

        Console.WriteLine("\nFull Details:");
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine(gatheringEvent.GetFullDetails());

        Console.WriteLine("\nShort Descriptions:");
        Console.WriteLine(lectureEvent.GetShortDescription());
        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine(gatheringEvent.GetShortDescription());

        Console.WriteLine("\n\n\n");

        Console.WriteLine("Press Enter to Close Data");
        Console.ReadLine();
        Console.Clear();
    }
}
