
public class ListingActivity : Activity
{
    private List<string> _listingPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void RunActivity()
    {
        StartActivity();

        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Pause(5);

        Console.WriteLine("Start listing items:");
        List<string> items = new List<string>();

        DateTime startTime = DateTime.Now;
        while (DateTime.Now - startTime < TimeSpan.FromSeconds(_duration))
        {
            string item = Console.ReadLine();
            items.Add(item);
        }

        Console.WriteLine($"You listed {items.Count} items.");

        EndActivity();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _listingPrompts.Count);
        return _listingPrompts[index];
    }
}
