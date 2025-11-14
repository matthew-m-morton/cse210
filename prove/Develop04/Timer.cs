public class Timer
{
    private static DateTime _targetTime;
    private static DateTime _tempTargetTime;


    public static void Set(int dur)
    {
        DateTime start = DateTime.Now;
        _targetTime = start.AddSeconds(dur);
    }
        public static void Set(int dur, string target)
    {
        DateTime start = DateTime.Now;
        _tempTargetTime = start.AddSeconds(dur);
    }

    public static bool IsExpired()
    {

        if (DateTime.Now > _targetTime)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
        public static bool IsExpired(string temp)
    {

        if (DateTime.Now > _tempTargetTime)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void PauseWithAnimation(int seconds)
    {
        List<string> animationStrings;
        animationStrings = ["|", "\\", "-", "/"];
        int counter = 0;
        Set(seconds,"temp");
        while (!IsExpired("temp"))
        {
            Console.Write($"{animationStrings[counter % animationStrings.Count]}");
            Thread.Sleep(150);
            Console.Write("\b");
            counter++;
        }
    }

        public static void Countdown(int seconds)
    {
        int counter = seconds;
        while(counter != 0 )
        {
            Console.Write(counter);
            Thread.Sleep(1000);
            Console.Write("\b");
            Console.Write(" ");
            Console.Write("\b");
            counter--;
        }

    
    }
}