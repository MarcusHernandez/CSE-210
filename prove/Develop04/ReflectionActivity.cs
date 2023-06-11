

public class ReflectionActivity : Activity
{
    private List<string> _reflectionPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _reflectionQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    protected override void Pause(int seconds)
    {
        string[] spinnerFrames = { "-", "/", "|", "\\" };
        int frameIndex = 0;

        for (int i = seconds; i >= 1; i--)
        {
            
            Console.Write($"\r{spinnerFrames[frameIndex]} ");
            frameIndex = (frameIndex + 1) % spinnerFrames.Length;
            Thread.Sleep(250);
        }
        Console.WriteLine();
    }


    public override void RunActivity()
    {
    StartActivity();

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_duration);

    while (DateTime.Now < endTime)
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("Press Enter when Ready");
        Console.ReadLine(); 

        foreach (string question in _reflectionQuestions)
        {
            if (DateTime.Now >= endTime) 
                break;

            Console.WriteLine(question);
            Pause(10*4);
        }
    }

    EndActivity();
}


    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _reflectionPrompts.Count);
        return _reflectionPrompts[index];
    }
}