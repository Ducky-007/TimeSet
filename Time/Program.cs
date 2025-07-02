// app that allows user to set time
using System;

public class TimeSet
{
    // assign hour, min and sec intervals
    public int Hour;
    public int Minute;
    public int Second;

    public static void Main()
    {
        TimeSet test = new TimeSet();
        // get user to input hour
        Console.Write("Enter hour: ");
        int userHour = int.Parse(Console.ReadLine());
        // get user to input minute
        Console.Write("Enter minutes: ");
        int userMinute = int.Parse(Console.ReadLine());
        // get user to input second
        Console.Write("Enter seconds: ");
        int userSecond = int.Parse(Console.ReadLine());
        test.SetTime(userHour, userMinute, userSecond);
        Console.WriteLine($"Time in AM/PM format: {test.ToString()}");
        Console.WriteLine($"Time in AM/PM format: {test.ToUniStr()}");
    }   

    public void SetTime(int hour, int minute, int second)
    {
        if ((hour < 0 || hour > 23))
        {
            throw new ArgumentOutOfRangeException(nameof(hour), hour, $"{nameof(Hour)} must be 0-23");
        }
        if ((minute < 0 || minute > 59))
        {
            throw new ArgumentOutOfRangeException(nameof(minute), minute, $"{nameof(Minute)} must be 0-59");
        }
        if ((second < 0 || second > 59))
        {
            throw new ArgumentOutOfRangeException(nameof(second), second, $"{nameof(Second)} must be 0-59");
        }
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }
    }
    public string ToUniStr() =>
        $"{Hour:D2}:{Minute:D2}:{Second:D2}";

    public override string ToString() =>
        $"{((Hour == 0 || Hour == 12) ? 12 : Hour % 12):D2}:" +
        $"{Minute:D2}:{Second:D2} {(Hour < 12 ? "AM" : "PM")}";
}