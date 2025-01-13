using System;

class Program
{
    static void Main(string[] args)
    {
        /*Console.Write("What is the magic number? ");*/
        /*int magicNumber=int.Parse(Console.ReadLine());*/
        Random randomGenerator= new Random();
        
        int guessNumber;
        
        string answer="yes";

        while (answer=="yes")
        {
            int magicNumber=randomGenerator.Next(1,100);
            int guessCount=0;
            do 
            {
                Console.Write("What is your guess? ");
                guessNumber=int.Parse(Console.ReadLine());
                
                if (guessNumber<magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNumber>magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
                guessCount=guessCount+1;
            }while (guessNumber!=magicNumber);
            
            Console.WriteLine($"You have tried {guessCount} times!");

            Console.WriteLine($"Do you want to play again Yes/No:");
            answer=Console.ReadLine();
            answer=answer.ToLower();
        }
    }
}