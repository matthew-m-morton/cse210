public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        base.InteractPrologue();
        InteractBreathing();
        base.InteractEpilogue();
    }


    public void InteractBreathing()
    {
        Timer.Set(_duration);
        while (!Timer.IsExpired())
        {
            Console.Write("Breathe in...");
            Timer.Countdown(4);
            if (Timer.IsExpired()) { break; }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Breathe out...");
            Timer.Countdown(4);
            Console.WriteLine();
            Console.WriteLine();
        }
        Console.WriteLine();

    }


}