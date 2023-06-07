using System;
using System.Collections.Generic;
using System.Threading;









public class Program
{
    public static void Main()
    {
        while (true)
        {
            DisplayMenu();
            int choice = GetMenuChoice();

            Activity activity;

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ReflectionActivity();
                    break;
                case 3:
                    activity = new ListingActivity();
                    break;
                default:
                    return;
            }

            Console.Clear();
            activity.Run();
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }

    private static void DisplayMenu()
    {
        Console.WriteLine("Choose an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit");
    }

    private static int GetMenuChoice()
    {
        Console.Write("Enter your choice: ");
        return int.Parse(Console.ReadLine());
    }
}
