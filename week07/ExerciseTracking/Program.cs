using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        
        Running running = new Running("2025-01-11",10,10);
        Running running1 = new Running("2025-01-14",10,20);
        // Console.WriteLine(running.GetSummary());

        Cycling cycling = new Cycling("2026-01-12",15,12);
        Cycling cycling1 = new Cycling("2026-01-15",10,15);
        // Console.WriteLine(cycling.GetSummary());
        
        Swimming swimming  = new Swimming("2021-11-13",20,6);
        Swimming swimming1  = new Swimming("2021-11-16",10,8);
        // Console.WriteLine(swimming.GetSummary());
        
        List<Activity> activities = new List<Activity>(){running,running1,cycling,cycling1,swimming,swimming1};
        
        Console.Clear();
        Console.WriteLine("Summary of Activities:");
        int i = 1;
        foreach (Activity activity in activities)
        {
            Console.Write($"  {i}: ");
            Console.WriteLine(activity.GetSummary());
            i++;
        }

    }

}