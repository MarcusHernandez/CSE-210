
public class BreathingActivity : Activity
{
    private List<string> _breathingPhrases = new List<string> { "Breathe in...", "Breathe out..." };

    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

 protected override void Pause(int seconds)
 {
    for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            if (i>=10 & i<=19){
            Console.Write("\b\b  \b\b");
            } else if(i>=1 & i<=9){
                Console.Write("\b \b");
            } else{
                Console.Write("\b\b\b    \b\b\b");
            }

        }
        Console.WriteLine();
 }

    public override void RunActivity()
    {
        StartActivity();

        int phraseIndex = 0;
        int durationCounter = 0;
        while (durationCounter < _duration)
        {
            Console.Write(_breathingPhrases[phraseIndex]);
            Pause(5);
            phraseIndex = (phraseIndex + 1) % _breathingPhrases.Count;
            durationCounter += 5;
        }

        EndActivity();
    }
}