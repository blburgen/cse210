using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activityList = new List<Activity>();
        RunningActivity runActivity = new RunningActivity(30,3);
        CyclingActivity cyclingActivity = new CyclingActivity(60,3);
        SwimmingActivity swimActivity = new SwimmingActivity(60,60);
        activityList.Add(runActivity);
        activityList.Add(cyclingActivity);
        activityList.Add(swimActivity);

        foreach (Activity item in activityList)
        {
            item.GetSummary();
        }

    }
}