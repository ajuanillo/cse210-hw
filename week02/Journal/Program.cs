using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Project.");
        string answer="yes";
        int choice=0;
            Journal newJournal= new Journal();
            
            while (answer=="yes")
            {
            Entry newEntry= new Entry();
            newEntry.Display();

            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());
            if (choice==1) {
                
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                newEntry._date=dateText;
                PromptGenerator newPrompt= new PromptGenerator();
                string prompt=newPrompt.GetRandomPrompt();
                newEntry._promptText=prompt;
                Console.WriteLine(prompt);
                newEntry._entryText=Console.ReadLine();
                
                newJournal.AddEntry(newEntry);

            }
            else if (choice==2) {
                newJournal.DisplayAll();
             }
            else if (choice==3){
                Console.Write("What is the filename to LOAD? ");
                string fileName=Console.ReadLine();
                newJournal.LoadFromFile(fileName);
            }
            else if (choice==4) {
                Console.Write("What is the filename to SAVE? ");
                string fileName=Console.ReadLine();
                newJournal.SaveToFile(fileName);
            }
            else if (choice==5) {
                answer="no";
            }
            else
            {
                Console.Write("This is not an option");
                answer="no";
            }
            }
            //Console.WriteLine(choice);
       
    }
}