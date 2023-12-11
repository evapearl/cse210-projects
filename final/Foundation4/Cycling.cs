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
        return GetLength() * CalculateSpeed() / 60;
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override double CalculatePace()
    {
        return 60 / CalculateSpeed();
        
    }

    public override void DisplaySummary()
    {
        Console.WriteLine($"{GetDate()} Cycling ({GetLength()} min) - Distance: {CalculateDistance()} miles, Speed: {CalculateSpeed()}, Pace : {CalculatePace()} min per mile");
    }
}