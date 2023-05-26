public class Prompt
{

    List<string> _promtps = new List<string>{

"What did you have for Lunch?",
"What did you have for Dinner?",
"What was the Highlight of your day?",
"What What would you do differenly today?",
"Who was the best person you talk to today?",
"What should you have done better today?",
"How do you handle stress today?",
"Why do you like programming?",
"What could you change about your code?"};

public Prompt()
{

}

public string GetPrompt()
{
    Random random = new Random();
    return _promtps[random.Next(_promtps.Count)];
}


}