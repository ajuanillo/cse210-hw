using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of number, type 0 when finished.");
        int number;
        int sum=0;
        int count=0;
        float average;
        List<int> numbers = new List<int>();
       
        do
        {
            Console.Write("Enter number: ");
            number=int.Parse(Console.ReadLine());
            if (number!=0)
            {
                numbers.Add(number);
                sum=sum+number;
                count=count+1;
            } 
        }while(number!=0);
        average=(float)sum/count;
        numbers.Sort();
        List<int> positives = new List<int>();
        
        foreach (int numb in numbers)
        {
            if(numb>0)
                positives.Add(numb);
        }
        Console.Write($"The sum is: {sum}\n");
        Console.Write($"The average is: {average}\n");
        Console.Write($"The largest number is: {numbers[numbers.Count-1]}\n");
        Console.Write($"The smallest positive number is: {positives[0]}\n");
        Console.WriteLine("The sorted is: ");
        foreach (int numb in numbers)
        {
            Console.WriteLine(numb);
        }
    }
}