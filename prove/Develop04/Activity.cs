
public abstract class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;

    protected Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    protected void StartActivity()
    {
        Console.WriteLine($"Starting {_activityName} activity...");
        Console.WriteLine(_description);
        SetDuration();
        Console.WriteLine("Get ready to begin...");
        Pause(3);
    }

    protected void EndActivity()
    {
        Console.WriteLine("Good job! You have completed the activity.");
        Console.WriteLine($"You have completed {_activityName} for {_duration} seconds.");
        Pause(5);
    }

      protected virtual void Pause(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write($"\rLoading... {i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }


    protected void SetDuration()
    {
        Console.Write("Enter the duration (in seconds): ");
        _duration = int.Parse(Console.ReadLine());
    }

    public abstract void RunActivity();
}