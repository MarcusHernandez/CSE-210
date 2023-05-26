public class Entry
{

    private string _prompt="";
    private string _response = "";
    private string _dataText = "";
    private string _structure = ",";

    public Entry()
    {
        _prompt = new Prompt().GetPrompt();
        DateTime theCurrentDate = DateTime.Now;
        _dataText = theCurrentDate.ToShortDateString();
    }

    public void SplitList(String[] items)
    {
        _dataText = items[0];
        _prompt = items[1];
        _response = items[2];
    }

    public void newPrompt()
    {
        Console.WriteLine(_prompt);
        _response = Console.ReadLine() ?? String.Empty;
    }

    public void Display()
    {
        Console.WriteLine($"{_dataText}\n{_prompt}\n{_response}");
    }

    public string Stringify()
    {
        return $"{_dataText}{_structure}{_prompt}{_structure}{_response}";
    }

}