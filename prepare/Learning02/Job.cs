using System;

public class Job
{
    //create member variable for each element
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // method to display job details on screen in correct format
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}