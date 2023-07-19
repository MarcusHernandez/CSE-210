using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running(new DateTime(2022, 12, 3), 30, 3.0));
        activities.Add(new Cycling(new DateTime(2022, 5, 3), 30, 6.0));
        activities.Add(new Swimming(new DateTime(2022, 7, 3), 30, 10));

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
