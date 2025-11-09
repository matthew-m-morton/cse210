public class Timer
{
    private static DateTime _targetTime;

    public static void Set(int dur)
    {
        DateTime start = DateTime.Now;
        _targetTime = start.AddSeconds(dur);
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

    public static void PauseWithAnimation(int seconds)
    {
        List<string> animationStrings;
        animationStrings = ["|", "\\", "-", "/"];
        int counter = 0;
        Set(seconds);
        while (!IsExpired())
        {
            Console.Write($"{animationStrings[counter % animationStrings.Count]}");
            Thread.Sleep(150);
            Console.Write("\b");
            counter++;
        }
    }
}