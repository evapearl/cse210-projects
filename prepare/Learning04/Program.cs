using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Rose Gary", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Rolian Hansen", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

       WritingAssignment a3 = new WritingAssignment("Evans Joel", "African History", "The Stop to the killing of Twins");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}