using System;

class Program
{
    static void Main(string[] args)
    {
        //int magicnum=0;
        //Console.Write("Please Enter a Magic Number: ");
        //magicnum = int.Parse(Console.ReadLine());
        Random randomnumber = new Random();
        int magicnum = randomnumber.Next(1,500);
        int guessnum = -1;
    while (guessnum!=magicnum)
    {
        Console.Write("Please Enter your Guess: ");
        guessnum = int.Parse(Console.ReadLine());
            if (guessnum<magicnum)
        {
            Console.WriteLine("Higher");
        }
            else if (guessnum > magicnum)
            {
                Console.WriteLine("Lower");
            }
            else{
                Console.WriteLine("You Guessed Right!");
            }
    }

    }
}