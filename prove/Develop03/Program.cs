 /* using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> scriptures = new Dictionary<string, string>
        {
            { "John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life." },
            { "Proverbs 3:5-6", "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight." }
        };

        foreach (var scripture in scriptures)
        {
            Console.Clear();
            Console.WriteLine($"{scripture.Key}: {scripture.Value}");
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                return;
            }

            string[] words = scripture.Value.Split();
            bool[] hiddenWords = new bool[words.Length];

            while (Array.IndexOf(hiddenWords, false) != -1)
            {
                Console.Clear();
                for (int i = 0; i < words.Length; i++)
                {
                    if (hiddenWords[i])
                    {
                        Console.Write("____ ");
                    }
                    else
                    {
                        Console.Write($"{words[i]} ");
                    }
                }
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

                input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    return;
                }

                int randomIndex = GetRandomHiddenWordIndex(hiddenWords);
                hiddenWords[randomIndex] = true;
            }
        }
    }

    static int GetRandomHiddenWordIndex(bool[] hiddenWords)
    {
        Random random = new Random();
        int index = random.Next(hiddenWords.Length);
        while (hiddenWords[index])
        {
            index = random.Next(hiddenWords.Length);
        }
        return index;
    }
} */

/* using System;
 using System.linq; 
class Program
{
    static void Main()
    {
        var scripture = new Scripture("John 3:16","For God....");
        var game = new ScriputreGame(scripture);

        Console.WriteLine("Press Enter to begin or type 'quit' to exit. ");
        var userInput = Console.ReadLine;

        if (userInput.ToLower() == "quit"){
            return;
        }

        Console.Clear();
        game.HideRandomWord();
        game.DisplayScripture();

        while (!game.AllWordsHidden)
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            userInput = Console.ReadLine();

            if (userInput.toLower() == "quit")
            {
                return;
            }
            Console.Clear();
            game.HideRandomWord();
            game.DisplayScripture();
        }
    }
}  */

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        while (!scripture.AllWordsHidden)
        {
            Console.Clear();
            scripture.Display();

            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                return;
            }

            scripture.HideRandomWord();
        }
    }
}





