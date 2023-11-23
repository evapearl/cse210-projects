using System;

public class SimpleGoal : Goal
{
    private string _type = "Simple Goal:";
    private bool _status;

    public SimpleGoal(string type, string name, string description, int points) : base (type, name, description, points)
    {
        _status = false;
    }
    public SimpleGoal(string type, string name, string description, int points, bool status) : base (type, name, description, points)
    {
        _status = status;
    }
    public Boolean End()
    {
        return _status;
    }

    public override void ListGoal(int i)
    {
        if (End() == false) 
        {
            Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})");
        }
        else if (End() == true)
        {
            Console.WriteLine($"{i}. [X] {GetName()} ({GetDescription()})");
        }
    }

    public override string SaveGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}");
    }
    public override string LoadGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}");
    }
    public override void RecordGoalEvent(List<Goal> goals)
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }
}