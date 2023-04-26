using System;

class Program
{

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string InputNameLast()
    {
        Console.Write("Please enter your last name: ");
        string namelast = Console.ReadLine();

        return namelast;
    }

    static string InputNameFirst()
    {
        Console.Write("Plase enter your First Name: ");
        string namefirst = Console.ReadLine();

        return namefirst;
    }
    static int InputNum()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int NumberSquared(int number)
    {
        int square = number * number;
        return square;
    }

    static void NameAndSquare(string namelast, string namefirst, int square)
    {
        Console.WriteLine($"{namelast}, {namefirst} {namelast}, the square of your number is {square}");
    }

        static void Main(string[] args)
    {
        WelcomeMessage();

        string userNameLast = InputNameLast();
        string userNameFirst = InputNameFirst();
        int userNumber = InputNum();

        int squaredNumber = NumberSquared(userNumber);

        NameAndSquare(userNameLast, userNameFirst, squaredNumber);
    }
}