public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            _points += _bonus;
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{this.GetType()}: {_name},{_description}, {_points},{_bonus},{_amountCompleted},{_target}";
    }

    public override string GetStringRepresentation()
    {
         string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_name} - ({_description} -- Completed {_amountCompleted}/{_target} times)";
    }
}
