using System;
/*
For this assignment, write a C# program that has several simple functions:
DisplayWelcome - Displays the message, "Welcome to the Program!"
PromptUserName - Asks for and returns the user's name (as a string)
PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
DisplayResult - Accepts the user's name and the squared number and displays them.
*/
class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName=PromptUserName();
        int userNumber=PromptUserNumber();
        int squaredNumber=SquareNumber(userNumber);
        DisplayResult(userName,squaredNumber); 
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Hello to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName=Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber=int.Parse(Console.ReadLine());
        return userNumber;
    }
    static int SquareNumber(int userNumber)
    {
        int squaredNumber=userNumber*userNumber;
        return squaredNumber;
    }
    static void DisplayResult(string name,int squared)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}");
    }
}