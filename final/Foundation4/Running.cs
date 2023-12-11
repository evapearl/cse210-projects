using System;

public abstract class Running : Activity
{
    private double _distance {get; set;}

    public Running(double length, double distance) : base(length)
    {
        _distance = distance;
    }

    public override double CalculateSpeed()
    {
        return CalculateDistance() / GetLength() * 60;
    }

    public override double CalculateDistance()
    {

        return _distance;
    }

    public override double CalculatePace()
    {
        return GetLength() / CalculateDistance();    
    }

    public override void DisplaySummary()
    {
        Console.WriteLine($"{GetDate()} Running ({GetLength()} min) - Distance: {CalculateDistance()} miles, Speed: {CalculateSpeed()}, Pace : {CalculatePace()} min per mile");
    }
}
