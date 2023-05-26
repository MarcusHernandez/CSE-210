Journal journalnew = new Journal();
SaveLoad file = new SaveLoad();
string message = string.Empty;
string choice = "";
while(choice != "5"){
    Menu(message);
    message = string.Empty;
    choice = Console.ReadLine() ?? string.Empty;
    switch (choice)
    {
        case "1":
        message = journalnew.AddEntry();
        break;
        case "2":
        journalnew.DisplayAllEntries();
        break;
        case "3":
        List<Entry> entries = file.LoadFile();
        journalnew.LoadEntries(entries);
        message = "Load successfully";
        break;
        case "4":
        file.WriteToFile(journalnew.GetEntries());
        message = "Saved Successfully";
        break;
        case "5":
        Environment.Exit(0);
        break;
    }

    void Menu (string message)
    {
        Console.Clear();
        if(message != string.Empty)
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<");
            Console.WriteLine(message);
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<");
        }
        Console.WriteLine("1 - Create Entry");
        Console.WriteLine("2 - Display All Entries");
        Console.WriteLine("3 - Load File");
        Console.WriteLine("4 - Save File");
        Console.WriteLine("5 - Exit\n");
        Console.Write("What Would you Like to Do?");
    }
}
