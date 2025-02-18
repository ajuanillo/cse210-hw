using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while(choice != 4)
        {
        Console.Clear();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflection activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");
        choice = Convert.ToInt32(Console.ReadLine());
        
        switch (choice)
        {
            case 1:
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathingActivity.Run();
                break;
            case 2:
            //     ReflectionActivity reflectionActivity = new ReflectionActivity();
            //     reflectionActivity.Run();
                break;
            case 3:
            //     ListingActivity listingActivity = new ListingActivity();
            //     listingActivity.Run();
                 break;
            case 4:
                Console.WriteLine("Goodbye!");
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a number between 1 and 4.");
                break;
        }
        }
        

    }
}