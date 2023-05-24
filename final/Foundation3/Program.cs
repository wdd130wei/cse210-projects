using System;

class Program
{
    static void Main(string[] args)
    {

        Address address1 = new Address("1 Queen Street", "Cityville", "Stateville", "United States");
        Lectures lecture = new Lectures("Awesome Lecture", "Join us for an exciting lecture", "21/05/2023", "09:00am", address1.GetAddress(), "John Smith", "100");

        Address address2 = new Address("2 Albert Street", "Townsville", "Stateville", "United States");
        Receptions reception = new Receptions("Fancy Reception", "Celebrate with us at our elegant reception", "21/05/2023", "10:00am", address2.GetAddress(), "rsvp@example.com");

        Address address3 = new Address("3 View Avenue", "Villageville", "Stateville", "United States");
        OutdoorGatherings gathering = new OutdoorGatherings("Summer BBQ", "Enjoy a fun-filled day with food and games", "21/05/2023", "11:00am", address3.GetAddress(), "Sunny");

        Console.WriteLine("Event 1:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.StandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(lecture.FullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(lecture.ShortDetails());
        Console.WriteLine();

        Console.WriteLine("Event 2:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(reception.StandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(reception.FullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(reception.ShortDetails());
        Console.WriteLine();

        Console.WriteLine("Event 3:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(gathering.StandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(gathering.FullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(gathering.ShortDetails());
    }
}