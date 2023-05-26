public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public Journal()
    {

    }
    public string AddEntry()
    {
        Entry newentry = new Entry();
        newentry.newPrompt();
        _entries.Add(newentry);
        return "Entry was added";
    }

    public void DisplayAllEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        Console.WriteLine("Press Enter to Continue");
        Console.ReadLine();
    }

    public void LoadEntries(List<Entry> entries)
    {
        _entries = entries;
    }
    public List<Entry> GetEntries()
    {
        return _entries;
    }

}