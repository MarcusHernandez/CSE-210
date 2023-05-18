
public class Journal
{

 public List<Entry> _journal = new List<Entry>();
 private string _userFileName;

 public Journal()
 {
 }
 public void Display()
 {
 Console.WriteLine("\n-------------- Journal Entries -----------------");
 foreach (Entry Entry in _journal)
 {
 Entry.getEntry();
 }
 Console.WriteLine("-------------- End ---------------");
 }
 
 public void SaveJournalFile(string _userFileName)
 {
 using (StreamWriter outputFile = new StreamWriter(_userFileName))
 {
 foreach (Entry journalentry in _journal)
 {
 outputFile.WriteLine($"{journalentry.dateTime},{journalentry.Prompt},{journalentry.jEntry}");
 }
 }
 }

 public void LoadJournalFile()
 {
    string[] lines = System.IO.File.ReadAllLines(_userFileName);
    foreach (string line in lines)
    {
        string[] parts = line.Split(",");

        string dateTime = parts[0];
        string journalPrompt = parts[1];
        string journalEntry = parts[2];
    }
 }
}
