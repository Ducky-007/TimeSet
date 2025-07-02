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
        test.SetTime(7, 22, 37);
        Console.Write($"Uni String: {test.ToUniStr()}\n");
        Console.WriteLine($"AM/PM String: {test.ToString()}");
    }

    public void SetTime(int hour, int minute, int second)
    {
        if ((hour < 0 || hour > 23) || (minute < 0 || minute > 59) || (second < 0 || second > 59))
        {
            throw new ArgumentException("Value wasn't in the required range. Fix and try again.");
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