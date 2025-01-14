using System;

public abstract class Goal
{
    private string _type;
    private string _name;
    private string _description;
    private int _points;

    public Goal(string type, string name, string description, int points)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
    }

    public new string GetType()
    {
        return _type;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }
    
    public int GetPoints()
    {
        return _points;
    }

    public abstract void ListGoal(int i);
    public abstract string SaveGoal();
    public abstract string LoadGoal();
    public abstract void RecordGoalEvent(List<Goal> goals);
    
}