using System;

public class Reception : Events
{
    private string _email {get; set;}

    public Reception(string title, string description, string date, string time, string addresses, string type, string email) : base (title, description, date, time, addresses, type)
    {
        _email = email;
    }

    public void DisplayReception()
    {
        DisplayFullDetail();
        Console.WriteLine($"E-mail :{_email}");
    }
}