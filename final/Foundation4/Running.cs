using System;

public abstract class Running : Activity
{
    private double _distance {get; set;}

    public Running(double length, double distance) : base(length, date)
    {
        _distance = distance;
    }

    public override double CalculateSpeed()
    {
        double speed = CalculateDistance() / GetLength() * 60;
        return _speed;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculatePace()
    {
        double pace = GetLength() / CalculateDistance();
        return pace;
    }

    public override void DisplaySummary()
    {
        Console.WriteLine($"{GetDate()} Running ({GetLength()} min) - Distance: {CalculateDistance()} miles, Speed: {CalculateSpeed()}, Pace : {CalculatePace()} min per mile");
    }
}
