using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, write your grade percentage: ");
        int grade=int.Parse(Console.ReadLine());
        string letterGrade="";
        string gradeSymbol="";
        if (grade>=90)
        {
            letterGrade="A";
        }
        else if (grade>=80)
        {
            letterGrade="B";
        }
        else if (grade>=70)
        {
            letterGrade="C";
        }
        else if (grade>=60)
        {
             letterGrade="D";
        }
        else 
        {  
            letterGrade="F";
        }
        if (grade>=60&&grade<97)
        {
            if ((grade%10)>=7)
            {
                gradeSymbol="+";
            }
            else if ((grade%10)<3)
            {
                gradeSymbol="-";
            }
            else
            {
                gradeSymbol="";
            }
        }
        else
        {
            gradeSymbol="";
        }
        Console.WriteLine($"Your letter grade is {letterGrade}{gradeSymbol}");
        if (grade>=70)
        {
            Console.WriteLine("Yo passed the curse!");
        }
        else
        {
            Console.WriteLine("You did not passed the curse, try again in next semester");
        }
    }
}