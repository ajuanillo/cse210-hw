using System.Threading.Tasks.Dataflow;

class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {   
        int choice = 0;
        while(choice != 6)
        {
        DisplayPlayerInfo();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("   1. Create New Goal");
        Console.WriteLine("   2. List Goals");
        Console.WriteLine("   3. Save Goals");
        Console.WriteLine("   4. Load Goals");
        Console.WriteLine("   5. Record Events");
        Console.WriteLine("   6. Quit");
        Console.Write("Select a choice from the menu: ");
        choice = Convert.ToInt32(Console.ReadLine());
        
        switch (choice)
        {
            case 1:
                CreateGoal();
                break;
            case 2:
                ListGoalDetails();
                break;
            case 3:
                 SaveGoals();
                 break;
            case 4:
                LoadGoals();
                break;
            case 5:
                RecordEvent();
                break;
            case 6:
                Console.WriteLine("Thanks!");
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a number between 1 and 6.");
                break;
        }
        Console.WriteLine();
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Points {_score}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
    }

    public void ListGoalDetails()
    {
        int t =1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{t} - {goal.GetStringRepresentation()}");
            t++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: ");
        ListGoalNames();
        Console.Write("Which type of goal would you like to create? ");
        int goalChoice = Convert.ToInt32(Console.ReadLine());
        if(goalChoice == 1)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = Convert.ToInt32(Console.ReadLine());
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if(goalChoice == 2)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = Convert.ToInt32(Console.ReadLine());
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if(goalChoice == 3)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = Convert.ToInt32(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
                
    }

    public void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Which goal did you accomplish? ");
        int goalChoice = Convert.ToInt32(Console.ReadLine());
        Goal goal = _goals[goalChoice - 1];
        goal.RecordEvent();
        _score += goal.GetPoints();
    }

    public void SaveGoals()
    {
        //Save the information.
        using (StreamWriter outputFile = new StreamWriter("goals.txt"))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetDetailsString());
            }
        }
    }

    public void LoadGoals()
    {
        // Load from goals.tx
        string[] lines = System.IO.File.ReadAllLines("goals.txt");
        _score = Convert.ToInt32(lines[0]);
        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split(":");
            string goalType = parts[0];
            string[] goalParts = parts[1].Split(",");
            string name = goalParts[0];
            string description = goalParts[1];
            int points = Convert.ToInt32(goalParts[2]);
            if(goalType == "SimpleGoal")
            {
                bool isComplete = Convert.ToBoolean(goalParts[3]);
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                if(isComplete)
                {
                    simpleGoal.RecordEvent();
                }
                _goals.Add(simpleGoal);
            }
            else if(goalType == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
            }
            else if(goalType == "ChecklistGoal")
            {
                int amountCompleted = Convert.ToInt32(goalParts[3]);
                int target = Convert.ToInt32(goalParts[4]);
                int bonus = Convert.ToInt32(goalParts[5]);
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                for(int i = 0; i < amountCompleted; i++)
                {
                    checklistGoal.RecordEvent();
                }
                _goals.Add(checklistGoal);
            }
        }
    }
}
