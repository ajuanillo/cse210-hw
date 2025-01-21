using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Here start the project week 02");
        Job job1= new Job();

        job1._jobTitle="Software engineer";
        job1._company="Microsoft";
        job1._startYear=2019;
        job1._endYear=2025;

        Job job2 = new Job();
        job2._jobTitle="Data Analyst";
        job2._company="Apple";
        job2._startYear=2018;
        job2._endYear=2024;
        // Console.WriteLine($"{job1._company}");
        // Console.WriteLine($"{job2._company}");
        // job1.Display();
        // job2.Display();
        
        Resume myResume=new Resume();

        myResume._name="Alfredo Juanillo";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        //Console.WriteLine($"{myResume._jobs[0]._jobTitle}");
        myResume.Display();
    }
}