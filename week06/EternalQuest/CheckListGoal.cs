class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"Progressed '{_shortName}'! +{_points} points!");

        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Goal complete! Bonus +{_bonus} points!");
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString() =>
        $"[{(_amountCompleted >= _target ? "X" : " ")}] {_shortName} ({_description}) -- Completed: {_amountCompleted}/{_target}";

    public override string GetStringRepresentation() =>
        $"CheckListGoal:{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
}
