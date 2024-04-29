using System;

public class Program
{
    public static string SecondsToTime(int seconds)
    {
        if (seconds > 359999) return "Invalid seconds";

        int hours = seconds / 3600;
        int minutes = (seconds % 3600) / 60;
        int remainingSeconds = seconds % 60;

        return $"{hours:D2}:{minutes:D2}:{remainingSeconds:D2}";
    }

    public static void Main()
    {
        Console.WriteLine(SecondsToTime(359999)); // Output: 99:59:59
        Console.WriteLine(SecondsToTime(3661));   // Output: 01:01:01
        Console.WriteLine(SecondsToTime(12345));  // Output: 03:25:45
    }
}
