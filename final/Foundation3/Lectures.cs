using System;

public class Lectures : Events
{
    private string _speaker {get; set;}
    private int _capacity {get; set;}

    public Lectures(string title, string description, string date, string time, string addresses, string type, string speaker, int capacity) : base (title, description, date, time, addresses, type)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void DisplayLecture()
    {
        DisplayFullDetail();
        Console.WriteLine($"Speaker :{_speaker}");
        Console.WriteLine($"Capacity : {_capacity}");
    }
}