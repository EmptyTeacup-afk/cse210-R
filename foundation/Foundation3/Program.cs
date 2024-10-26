using System;
public class Program
{
    public static void Main()
    {
        var activities = new List<Activity>
        {
            new RunningActivity(new DateTime(2022, 11, 3), 30, 4.8),
            new CyclingActivity(new DateTime(2022, 11, 4), 45, 20),
            new SwimmingActivity(new DateTime(2022, 11, 5), 35, 40)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}