
/* 
Prompt _prompt = new Prompt();
 _prompt.AddJournal(new Journal("How was Lunch Today?","",""));
 _prompt.AddJournal(new Journal("How was Dinner Today?","",""));
 _prompt.GetRandomPrompt(); */
///////////////////////////////////////
 /* class Program
{
static void Main(string[] args)
{
    int[] validNumbers = { 1, 2, 3, 4, 5 };
    int action = 0;
    Console.Clear();
    Console.Write("\nWelcome to the Journal Program! \n");
    Console.ResetColor();

 // Create new journal reference/list
    Journal journal = new Journal();
    JournalPrompt jp = new JournalPrompt();
    while (action != 5)
    {
 // Ask for user input (1-5)
 //Call Choices
        action = Choices();
        switch (action)
        {
            case 1: // Write Journal Entry
            //string entryId = GetEntryId();
            string dateInfo = GetDateTime();
            string prompt = jp.GetPrompt();
            JournalEntry entry = new JournalEntry();
            //entry._entryNumber = entryId;
            entry._dateTime = dateInfo;
            entry._journalPrompt = prompt;
            Console.Write($"{prompt}\n");
            Console.Write("--> ");
            string userEntry = Console.ReadLine();
            entry._journalEntry = userEntry;
            journal._journal.Add(entry);
            Console.Clear();
            break;
            case 2: // Display Journal Entries
            journal.Display();
            break;
            case 3: // Load text file
            journal.LoadJournalFile();
            break;
            case 4: // Save to text file
            journal.CreateJournalFile();
            break;
            case 5: // Quit
            Console.WriteLine("\nThank you for using the Journal Program!\n");
            Console.ResetColor();
            break;
        }
    }
}
 static int Choices()
 // Method to display choices to user
 {
    Console.Write("\nPlease select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n\nWhat would you like to do? ");
    string choices ="";
    Console.Write(choices);
    string userInput = Console.ReadLine();
    Console.Clear();
    int action = 0;
    // It catches any non integer values that are entered.
    try
    {
        action = int.Parse(userInput);
    }
    catch (FormatException)
        {
            action = 0;
        }
    catch (Exception exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Unexpected error: {exception.Message}");
            Console.ResetColor();
        }
    return action;
 }
 static string GetDateTime()
 // GetTing the date and time for journal record
 {
    DateTime now = DateTime.Now;
    string currentDateTime = now.ToString("F");
    return currentDateTime;
 }
    static void AddJournalEntry()
 // Method to add entry to text file
 {
    string MyJournalFile = "MyJournal.txt";
    File.AppendAllText(MyJournalFile, "");
 }
} */
Prompt _prompt = new Prompt();
_prompt.AddPrompt(new Prompt("What did you have for Lunch?"));
_prompt.AddPrompt(new Prompt("What did you have for Dinner?"));
_prompt.AddPrompt(new Prompt("What was the Highlight of your day?"));
_prompt.AddPrompt(new Prompt("What What would you do differenly today?"));
_prompt.AddPrompt(new Prompt("Who was the best person you talk to today?"));
_prompt.AddPrompt(new Prompt("What should you have done better today?"));
_prompt.AddPrompt(new Prompt("How do you handle stress today?"));
_prompt.AddPrompt(new Prompt("Why do you like programming?"));
_prompt.AddPrompt(new Prompt("What could you change about your code?"));

Menu _menu = new Menu(_prompt);
_menu.Display();