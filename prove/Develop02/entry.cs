public class Entry
{
    private string _dateTime = "";
    private string _Prompt = "";
    private string _Entry = "";
    public string _File = "";
    internal object dateTime;
    internal object Prompt;
    internal object jEntry;

    public Entry(string dateTime, string Prompt, string jEntry)
    {
        _dateTime = dateTime;
        _Prompt = Prompt;
        _Entry = jEntry;
    }
    public string getEntry()
    {
        return $"{_dateTime}\n, {_Prompt}\n, {_Entry}\n";
    }
 }