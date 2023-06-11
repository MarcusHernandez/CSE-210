
using System;
using System.Collections.Generic;
using System.Threading;

public class Program
{
    public static void Main(string[] args)
    {
        

        int choice;
        do
        {
            Console.WriteLine("===== ACTIVITY MENU =====");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("=========================");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Activity breathingActivity = new BreathingActivity();
                    breathingActivity.RunActivity();
                    break;
                case 2:
                    Activity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.RunActivity();
                    break;
                case 3:
                    Activity listingActivity = new ListingActivity();
                    listingActivity.RunActivity();
                    break;
                case 4:
                    Console.WriteLine("Exiting the program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        } while (choice != 4);
    }
}
