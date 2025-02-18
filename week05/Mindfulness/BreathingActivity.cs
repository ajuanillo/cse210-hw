using System.Security.Cryptography.X509Certificates;

class BreathingActivity : Activity
{
    public  BreathingActivity(string name,string description) : base (name,description)
    {

    }
    public void Run()
    {
        DisplayStartingMessage(); // Base Class "Activity"

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4);
            Console.Write("Breathe out... ");
            ShowCountDown(6);
        }
        
        DisplayEndingMessage();     // Base Class "Activity"
    }
}