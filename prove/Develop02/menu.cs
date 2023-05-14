public class Menu
{
    private Prompt _prompt;
    Journal journal = new Journal();
    Prompt jp = new Prompt();
    private Prompt promptdata;

    public Menu(Prompt prompt)
    {
        _prompt = prompt;
    }

    public void Display()
    {
        int response=0;
        int[] options = {1,2,3,4,5};
        while(response!=5)
        {
            while(options.Contains(response)==false)
            {
                    Console.Write("\nPlease select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n\nWhat would you like to do? ");
                response = int.Parse(Console.ReadLine());
            }
            switch (response)
        {
            case 1:
            string dateInfo = GetDateTime();
             string prompt = jp.GetPrompt();
           
            Console.WriteLine($"{_prompt.GetRandomPrompt}\n");
            Console.Write("--> ");
            string userEntry = Console.ReadLine();
            Entry entry = new Entry(dateInfo,promptdata,userEntry);
            entry.jEntry = userEntry;
             entry.dateTime = dateInfo;
            entry.Prompt = prompt;
            journal._journal.Add(entry);
            break;
            case 2:
            journal.Display();
            break;
            case 3: 
            journal.LoadJournalFile();
            break;
            case 4: 
            Console.Write("Please Enter your file name");
            string _userFileName = Console.ReadLine();
            journal.SaveJournalFile(_userFileName);
            break;
            case 5: // Quit
            Console.WriteLine("\nThank you for using the Journal Program!\n");
            break;
            }
        if (response == 5)
        {
            response = 5;
        }
        else 
            response = 0; 
        }   
    }
    
    public String GetDateTime()
    {
    DateTime theCurrentTime = DateTime.Now;
    string datenow = theCurrentTime.ToShortDateString();
    return datenow;
    }
    public void AddJournalEntry()
    {
        {
    string MyJournalFile = "MyJournal.txt";
    File.AppendAllText(MyJournalFile, "");
 }
    }

}