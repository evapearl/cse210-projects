using System;

public abstract class Swimming : Activity
{
    private int _laps {get; set;}

    public Swimming(double length, int laps) : base(length)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        double distance = _laps * 50 / 1000 * 0.62;
        return distance;
    }

    public override double CalculatePace()
    {
        return GetLength() / CalculateDistance();
    }

    public override double CalculateSpeed()
    {
        return CalculateDistance() / GetLength() * 60;
    }

    public override void DisplaySummary()
    {
        Console.WriteLine($"{GetDate()} Swimming ({GetLength()} min) - Distance: {CalculateDistance()} miles, Speed: {CalculateSpeed()}, Pace : {CalculatePace()} min per mile");
    }
}