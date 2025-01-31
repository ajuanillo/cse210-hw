using System;

class Program
{
    static void Main(string[] args)
    {
        string answer="";

        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference r1 = new Reference ("Jhon",17,21);
        string t1="That they all may be one; as thou, Father , art in me, and I in thee, that they also may be one in us: that the world may believe that thou hast sent me.";
        Scripture sc1 = new Scripture(r1,t1);

        while (answer.ToLower()!="quite" && sc1.IsCompleteHidden()==false)
        {
            // This will clear the console
            Console.Clear();

            Console.WriteLine(sc1.GetDisplay());
            
            //Write message and waiting for the user to press the enter key
            Console.WriteLine("\nPress ENTER to continue learning or type Quite to finish: ");
            answer=Console.ReadLine();

            sc1.HideRandomWords(2);

            if(sc1.IsCompleteHidden()==true)
            {
                Console.Clear();
                Console.WriteLine(sc1.GetDisplay());
            }
        }
    }
}