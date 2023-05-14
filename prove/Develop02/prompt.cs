
public class Prompt
{

private string _prompt = "";
public Prompt(string prompt)
{
    _prompt = prompt;
}

    public Prompt()
    {
    }

    public List<Prompt> _jPrompt = new List<Prompt>();

 public void AddPrompt(Prompt prompt)
    {
        _jPrompt.Add(prompt);
    }
 /* public Prompt()
 {
 } */

 public void GetRandomPrompt()
    {
        var random = new Random();
        var randomNumber = random.Next(0,_jPrompt.Count);
        _jPrompt[randomNumber].GetPrompt();
    }

public string GetPrompt()
{
    return $"{_prompt}";
}
}
