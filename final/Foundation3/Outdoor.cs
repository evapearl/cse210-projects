using System;

public class Outdoor : Events
{
    private string _weather {get; set;}

    public Outdoor(string title, string description, string date, string time, string addresses, string type, string weather) : base (title, description, date, time, addresses, type)
    {
        _weather = weather;
    }

    public void DisplayOutdoorDetail()
    {
        DisplayFullDetail();
        Console.WriteLine($"Weather :{_weather}");
    }
}