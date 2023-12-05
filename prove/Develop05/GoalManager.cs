using System;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints;

    public GoalManager()
    {
        _totalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public void AddPoints(int points)
    {
        _totalPoints += points;
    }

    public void AddBonus(int bonusPoints)
    {
        _totalPoints += bonusPoints;
    }

    public void SetTotalPoints(int totalPoints)
    {
        _totalPoints = totalPoints;
    }

    public List<Goal> GetGoalList()
    {
        return _goals;
    }

    public void ListGoal()
    {
        if (_goals.Count() > 0)
        {
            Console.WriteLine("Your Goals are:");
            int index = 1;
            foreach (Goal goal in _goals)
            {
                goal.ListGoal(index);
                index ++;
            }
        }
        else
        {
            Console.WriteLine("You currently have no goals");
        }
    }
    public void RecordGoalEvent()
    {
        ListGoal();
        Console.WriteLine("Which goal did you completed? ");
        int choice = int.Parse(Console.ReadLine())-1;
        int goalPoints = GetGoalList()[choice].GetPoints();
        AddPoints(goalPoints);
        
        GetGoalList()[choice].RecordGoalEvent(_goals);
        
        Console.WriteLine($"*** You have {GetTotalPoints()} points! ***");
    }
    public void SaveGoals()
    {
        Console.Write("What is the name for this goal file? ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        using (StreamWriter outputFile = new  StreamWriter(userFileName))
        {
            outputFile.WriteLine(GetTotalPoints());

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }
    
    public void LoadGoal()
    {
        Console.Write("What is the name of the goal file? ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        if (File.Exists(userFileName))
        {
            string[] readText = File.ReadAllLines(userFileName);

            int totalPoints = int.Parse(readText[0]);
            SetTotalPoints(totalPoints);

            readText = readText.Skip(1).ToArray();
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");

                string type = entries[0];
                string name = entries[1];
                string description = entries[2];
                int points = int.Parse(entries[3]);
                bool status = Convert.ToBoolean(entries[4]);

                if (entries[0] == "Simple Goal:")
                {
                    SimpleGoal sGoal = new SimpleGoal(type, name, description, points, status);
                    AddGoal(sGoal);
                }

                else if (entries[0] == "Eternal Goal:")
                {
                    EternalGoal eGoal = new EternalGoal(type, name, description, points, status);
                    AddGoal(eGoal);
                }

                else if(entries[0] == "Goal Checklist:")
                {
                    int numberTimes = int.Parse(entries[5]);
                    int bonusPoints = int.Parse(entries[6]);
                    int counter = int.Parse(entries[7]);
                    GoalChecklist clGoal = new GoalChecklist(type, name, description, points, status, numberTimes, bonusPoints, counter);
                    AddGoal(clGoal);
                }
            }
        }
    }
}