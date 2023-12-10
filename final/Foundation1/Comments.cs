using System;

public class Comment
{
    public string _name;
    public string _commentTxt;

    public void DisplayComment()
    {
        Console.WriteLine($"{_name}: {_commentTxt}");
    }
}