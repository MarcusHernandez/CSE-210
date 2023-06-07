public class BreathingActivity : Activity
{
    private string[] _breathingMessages = { "Breathe in...", "Breathe out..." };

    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    private void PerformActivity()
    {
        for (int i = 0; i < GetDuration(); i++)
        {
            Console.WriteLine(_breathingMessages[i]);
            Pause(2);
            i++;
            if (i>=2){
                i=0;
            }
        }
    }
}