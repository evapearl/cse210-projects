using System;

public abstract class Swimming : Activity
{
    private int _laps {get; set;}

    public Swimming(double length, int laps) : base(length, date)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        double distance = _laps * 50 / 1000 * 0.62;
        return _distance;
    }

    public override double CalculatePace()
    {
        double pace = GetLength() / CalculateDistance();
        return pace;
    }

    public override double CalculateSpeed()
    {
        double speed = CalculateDistance() / GetLength() * 60;
        return _speed;
    }

    public override void DisplaySummary()
    {
        Console.WriteLine($"{GetDate()} Swimming ({GetLength()} min) - Distance: {CalculateDistance()} miles, Speed: {CalculateSpeed()}, Pace : {CalculatePace()} min per mile");
    }
}