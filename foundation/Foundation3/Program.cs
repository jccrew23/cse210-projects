using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        DateTime thisDate1 = new DateTime(2024, 10, 24);
        Running run = new Running(thisDate1,30,6.6);
        run.Run();
        activities.Add(run);
        Spinning bike = new Spinning(thisDate1,50,15.9);
        bike.Run();
        activities.Add(bike);
        Swimming swim = new Swimming(thisDate1,35,13);
        swim.Run();
        activities.Add(swim);

        foreach (Activity a in activities) {
            a.GetSummary();
        }
    }
}