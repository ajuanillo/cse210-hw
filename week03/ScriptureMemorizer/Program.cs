using System;

class Program
{
    static void Main(string[] args)
    {
        string answer="";

        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        
        //Showing Creativity
        //Choosing scriptures at random to present to the user.

        Reference[] r1 ={ new Reference ("Jhon",17,21), 
                          new Reference ("Luke",2,11,12),
                          new Reference ("Matthew",2,11)}; 
        string[] t1={
                    "That they all may be one; as thou, Father , art in me, and I in thee, that they also may be one in us: that the world may believe that thou hast sent me.",
                    "11 For unto you is born this day in the city of David a Saviour, which is Christ the Lord. 12 And this shall be a sign unto you; Ye shall find the babe wrapped in swaddling clothes, lying in a manger. ",
                    "11 ¶ And when they were come into the house, they saw the young child with Mary his mother, and fell down, and worshipped him: and when they had opened their treasures, they presented unto him gifts; gold, and frankincense, and myrrh."
                    };
        Random rnd = new Random();
        int index=rnd.Next(t1.Length);
        
        Scripture sc1 = new Scripture(r1[index],t1[index]);

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