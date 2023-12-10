using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation4 World!");

        Running running = new Running(30, 5);
        activityList.Add(running);

        Cycling cycling = new Cycling(45, 12);
        activityList.Add(cycling);

        Swimming swimming = new Swimming(60, 20);
        activityList.Add(swimming);

        foreach (Activity activity in activityList)
        {
            activity.DisplaySummary();
        }
    }
}