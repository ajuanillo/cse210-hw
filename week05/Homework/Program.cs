using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        // Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        // Console.WriteLine(assignment.GetSummary());

        // MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        // Console.Clear();
        // Console.WriteLine(mathAssignment.GetSummary());
        // Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.Clear();
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());


    }
}