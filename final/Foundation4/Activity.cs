using System;

public abstract class Activity
{
    private string _Adate {get; set;}
    private double _length {get; set;}

    public Activity(double length, string date)
    {
        _length = length;
        _Adate = date;
    }

    public string GetDate()
    {
        DateTime date = DateTime.now;
        string _Adate = date.ToString("DD MM YYYY");
        return _Adate;
    }

    public double GetLength()
    {
        return _length;
    }

    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculateSummary();
}