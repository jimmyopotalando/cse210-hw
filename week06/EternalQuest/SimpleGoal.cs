class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Completed '{_shortName}'! +{_points} points!");
    }

    public override bool IsComplete() => _isComplete;

    public override string GetDetailsString() =>
        $"[{(_isComplete ? "X" : " ")}] {_shortName} ({_description})";

    public override string GetStringRepresentation() =>
        $"SimpleGoal:{_shortName}|{_description}|{_points}|{_isComplete}";
}
