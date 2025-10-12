public class Prompt
{
    static Random _randomProducer = new Random();
    static List<string> _prompts = new List<string>{
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What did I learn about myself today?",
        "What challenge did I face today, and how did I handle it?",
        "What am I most grateful for today?",
        "Who did I serve or help today?",
        "What moment made me smile or laugh the most?",
        "What is something I want to improve on tomorrow?",
        "How did I show kindness or love today?",
        "What decision did I make today that I feel good about?",
        "What scripture or spiritual thought stood out to me today?",
        "How did I feel the Spirit guide me today?"
    };

    public string GeneratePrompt()
    {
        int _selectedPromptIndex = _randomProducer.Next(0,_prompts.Count()-1);

        string _prompt;
        _prompt = _prompts[_selectedPromptIndex];
        return _prompt;
    }
}