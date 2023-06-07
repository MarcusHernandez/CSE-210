public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetDuration()
    {
        Console.Write("Enter the duration for the activity (in seconds): ");
        return int.Parse(Console.ReadLine());
    }

    public void Run()
    {
        DisplayStartingMessage();
        PrepareToBegin();
        PerformActivity();
        DisplayEndingMessage();
    }

    private void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name} activity...");
        Console.WriteLine(_description);
        _duration = GetDuration();
        Console.WriteLine("Prepare to begin...");
        Pause(3);
    }

    private void PrepareToBegin()
    {
        Console.WriteLine("Get ready...");
        Pause(3);
    }

    private void PerformActivity()
    {
        Console.WriteLine("Activity in progress...");
        Pause(_duration);
    }

    private void DisplayEndingMessage()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {_name} activity.");
        Console.WriteLine($"Total time: {_duration} seconds");
        Pause(3);
    }

    protected void Pause(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b  \b\b");
        }
        Console.WriteLine();
    }
}