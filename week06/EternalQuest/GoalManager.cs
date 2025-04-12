class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private int _level = 1;

    public void Start()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine($"\n⭐ Score: {_score} | 🧙 Level: {_level}");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Add Negative Event");
            Console.WriteLine("7. Quit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalNames(); break;
                case "3": RecordEvent(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": RecordNegativeEvent(); break;
                case "7": running = false; break;
                default: Console.WriteLine("Invalid option."); break;
            }

            CheckLevelUp();
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Goal Type:\n1. Simple\n2. Eternal\n3. Checklist");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else if (type == "3")
        {
            Console.Write("How many times must it be completed? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus points when completed: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new CheckListGoal(name, desc, points, target, bonus));
        }
    }

    public void ListGoalNames()
    {
        Console.WriteLine("\n📜 Current Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you complete? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        Goal goal = _goals[index];
        goal.RecordEvent();

        if (goal is CheckListGoal clg)
        {
            _score += clg.IsComplete() && clg._amountCompleted == clg._target
                ? clg._points + clg._bonus
                : clg._points;
            if (clg.IsComplete()) PrintBadge("Checklist Master");
        }
        else if (goal is SimpleGoal sg && !sg.IsComplete())
        {
            _score += sg._points;
            PrintBadge("Goal Crusher");
        }
        else if (goal is EternalGoal eg)
        {
            _score += eg._points;
        }
    }

    public void RecordNegativeEvent()
    {
        Console.Write("What bad habit did you do? (e.g., skipped prayer, drank soda): ");
        string badHabit = Console.ReadLine();

        Console.Write("How many points should you lose? ");
        int penalty = int.Parse(Console.ReadLine());

        _score -= penalty;
        Console.WriteLine($"☠️ You lost {penalty} points for '{badHabit}'. Stay strong next time!");
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            writer.WriteLine(_level);
            foreach (Goal g in _goals)
            {
                writer.WriteLine(g.GetStringRepresentation());
            }
        }

        Console.WriteLine("✅ Goals and progress saved.");
    }

    public void LoadGoals()
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines("goals.txt");
        _score = int.Parse(lines[0]);
        _level = int.Parse(lines[1]);

        foreach (string line in lines.Skip(2))
        {
            string[] parts = line.Split(":");
            string type = parts[0];
            string[] data = parts[1].Split("|");

            switch (type)
            {
                case "SimpleGoal":
                    var sg = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                    if (bool.Parse(data[3])) sg.RecordEvent(); // force complete
                    _goals.Add(sg);
                    break;

                case "EternalGoal":
                    _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                    break;

                case "CheckListGoal":
                    var clg = new CheckListGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]));
                    clg._amountCompleted = int.Parse(data[5]); // accessing internal state (you could expose a setter method for a cleaner OOP approach)
                    _goals.Add(clg);
                    break;
            }
        }

        Console.WriteLine("📂 Goals loaded!");
    }

    private void CheckLevelUp()
    {
        int newLevel = (_score / 1000) + 1;
        if (newLevel > _level)
        {
            _level = newLevel;
            Console.WriteLine($"\n🎉 YOU LEVELED UP! You are now Level {_level}!");
            PrintBadge($"LEVEL {_level}");
        }
    }

    private void PrintBadge(string title)
    {
        Console.WriteLine($"\n🏅 BADGE UNLOCKED: {title} 🏅");
        Console.WriteLine(@"
     █████╗  █████╗  █████╗ 
    ██╔══██╗██╔══██╗██╔══██╗
    ███████║███████║███████║
    ██╔══██║██╔══██║██╔══██║
    ██║  ██║██║  ██║██║  ██║
    ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝
");
    }
}
