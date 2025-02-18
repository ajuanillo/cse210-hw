class ListingActivity : Activity
{
    int _count = 0;
    int _index = 0;
    List<string> items = new List<string>();
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description) : base(name, description)
    {
       
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        GetListFromUser();

        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();
        DisplayPromptAndItems();
        ShowSpinner(3);
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            items.Add(item);
            _count++;
        }
        return items;
    }
    public void DisplayPromptAndItems()
    {
        Console.WriteLine($"Answers for {_prompts[_index]}");
        foreach (string item in items)
        {
            Console.WriteLine(item);
        }
        
    }
}