using System;

public class GoalChecklist : Goal 
{

    private string _type = "Goal Checklist:";
    protected int _numberTimes;
    protected int _count;
    private bool _status;
    private int _bonusPoints;


    public GoalChecklist(string name, string type, string description, int bonusPoints, int numberTimes, int points) : base(type, description, name, points)
    {
        _status = false;
        _bonusPoints = bonusPoints;
        _count = 0;
        _numberTimes = numberTimes;
    }

    public GoalChecklist(string name, string type, string description, int bonusPoints, int numberTimes, int points, bool status, int count) : base(type, description, name, points)
    {
        _status = status;
        _bonusPoints = bonusPoints;
        _count = count;
        _numberTimes = numberTimes;
    }
    public int GetTimes()
    {
        return _numberTimes;
    }
    public void SetTimes(int numberTimes)
    {
        _numberTimes = numberTimes;
    }
    public int  GetBonusPoints()
    {
        return _bonusPoints;
    }
    public void SetBonusPoints(int bonusPoints)
    {
        _bonusPoints = bonusPoints;
    }
    public int GetCount()
    {
        return _count ;
    }
    public void SetCount()
    {
        _count =+ 1;
    }
    public  Boolean End()
    {
        return _status;
    }
    public override  void  ListGoal(int i)
    {
        if (End() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetName()} {GetDescription()}) -- Currently Completd: {GetCount()} / {GetTimes()}");
        }
        else if (End() == true)
        {
            Console.WriteLine($"{i}. [X] {GetName()} {GetDescription()}) -- Completd: {GetCount()} / {GetTimes()}");
        }
    }
    public override string SaveGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}; {GetTimes()}; {GetBonusPoints()}; {GetCount()}");
    }
    public override string LoadGoal()
    {
        return ($"Simple Goal:; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}; {GetTimes()}; {GetBonusPoints()}; {GetCount()}");
    }
    public override void RecordGoalEvent(List<Goal> goals)
    {



        SetTimes();
        int points = GetPoints();

        if (_count == numberTimes)
        {
            _status = true;
            points += _bonusPoints;
            
            Console.WriteLine($"Congratulations! You have earned {points} points");
        }
        else 
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points");
        }

    }
}