using System;

public class Events 
{
    private string _title {get; set;}
    private string _description {get; set;}
    private string _date {get; set;}
    private string _time {get; set;}
    private string _address {get; set;}
    private string _eventType {get; set;}

    public Events(string title, string description, string date, string time, string address, string type )
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = type;
    }

    public void DisplayStandardDetail()
    {
        Console.WriteLine($"Title : {_title}");
        Console.WriteLine($"Description : {_description}");
        Console.WriteLine($"Date : {_date}");
        Console.WriteLine($"Time : {_time}");
        Console.WriteLine($"Address : {_address}");
    }

    public void DisplayFullDetail()
    {
        Console.WriteLine($"Event : {_eventType}");
        Console.WriteLine($"Title : {_title}");
        Console.WriteLine($"Description : {_description}");
        Console.WriteLine($"Date : {_date}");
        Console.WriteLine($"Time : {_time}");
        Console.WriteLine($"Address: {_address}");
    }

    public void DisplayShortDescription()
    {
        Console.WriteLine($"Event : {_eventType}");
        Console.WriteLine($"Title : {_title}");
        Console.WriteLine($"Date : {_date}");
    }
}