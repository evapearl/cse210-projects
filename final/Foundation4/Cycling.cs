using System;

public abstract class Cycling : Activity
{
    private double _speed {get; set;}

    public Cycling(double length, double speed) : base(length)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        double distance = GetLength * CalculateSpeed() / 60;
        return distance;
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override double CalculatePace()
    {
        double pace = 60 / CalculateSpeed();
        return pace;
    }

    public override void DisplaySummary()
    {
        Console.WriteLine($"{GetDate()} Cycling ({GetLength()} min) - Distance: {CalculateDistance()} miles, Speed: {CalculateSpeed()}, Pace : {CalculatePace()} min per mile");
    }
}