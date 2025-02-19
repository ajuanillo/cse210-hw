public class SimpleGoal : Goal
{
    private bool _isCompleted;
    public SimpleGoal(string name, string description,int points) : base (name,description, points)
    {
        _isCompleted = false;
    }

    public override void RecordEvent()
    {
        _isCompleted=true;
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
    }
    public override bool IsComplete()
    {
        return _isCompleted;
    }
    public override string GetStringRepresentation()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_name} - {_description}.";
    }
}

