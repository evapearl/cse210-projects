using System;

public class GoalMenu
{
    private string _menu = $@"
    
    Goal Menu Options
    =================================
    The Goals to play are:
    1. Simple Goal
    2. Eternal Goal
    3. Goal Checklist
    4. Bad Habit Goal
    5. Back to Main Menu
    ==================================
    What kind of goal would  you like to work on? ";

    public string _goalInput;
    private int _goalChoice = 0;

    public int GoalChioce()
    {
        Console.Write(_menu);
        _goalInput = Console.ReadLine();
        _goalChoice = 0;

        try
        {
            _goalChoice = int.Parse(_goalInput);
        }
        catch (FormatException)
        {
            _goalChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error: {exception.Message}");
        }
        return _goalChoice;
    }

}