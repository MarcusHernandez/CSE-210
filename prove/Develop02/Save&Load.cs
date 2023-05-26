public class SaveLoad
{
    private string _userFileName = "journal.txt";

    public void WriteToFile(List<Entry> entries)
    {
        string FileName = PromptFileName($"What File would you like to save to ({_userFileName})");
        using (StreamWriter outputFile = new StreamWriter(FileName))
        foreach (var entry in entries)
        {
            outputFile.WriteLine(entry.Stringify());
        }
    }

    public string PromptFileName(string prompt)
    {
        Console.Write(prompt);
        string FileName = Console.ReadLine() ?? string.Empty;
        FileName = FileName == string.Empty? _userFileName : FileName;
        return FileName;
    }

    public List<Entry> LoadFile()
    {
        string FileName = PromptFileName($"What file would you like to load ({_userFileName})");
        string[] lines = System.IO.File.ReadAllLines(FileName);
        List<Entry> entries = new List<Entry>();
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Entry newentry = new Entry();
            newentry.SplitList(parts);
            entries.Add(newentry);
        }
        return entries;
    }
}