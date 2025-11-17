public class ListingActivity : Activity
{
    private List<string> _questions = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?",
        "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        InteractPrologue();
        InteractListing();
        InteractEpilogue();
    }
    
    public void InteractListing()
    {
        Random random = new Random();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine(" --- " + _questions[random.Next(0, _questions.Count() - 1)] + " --- ");
        Console.WriteLine("You may begin in: ");
        Timer.Countdown(5);
        Console.Clear();
        List<string> responses = new List<string>{};

        Timer.Set(base._duration);
        while (!Timer.IsExpired())
        {
            Console.Write(">");
            string response = Console.ReadLine();
            responses.Add(response);
        }

        Console.WriteLine($"You listed {responses.Count()} items!");
        
    }
}