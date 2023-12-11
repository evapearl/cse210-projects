using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation3 World!");


        EventAddress address1 = new EventAddress( "James Watt", "Benin", "Edo", "Nigeria");
        string lectureAddress = address1.GetEventAddress();
        Lectures lecture = new Lectures("Primary Anniversary", "celebrating the organization of primary", "October 16", "12:00pm - 2:00pm", $"{lectureAddress}", "Lecture", "Destiny Uyimwen", 350);

        Console.WriteLine("------------------------");
        lecture.DisplayShortDescription();
        Console.WriteLine();

        lecture.DisplayStandardDetail();
        Console.WriteLine();

        lecture.DisplayLecture();


        EventAddress address2 = new EventAddress( "Mobile Crese", "Benin", "Edo", "Nigeria");
        string receptionAddress = address2.GetEventAddress();
        Reception reception = new Reception("Beautiful plus one", "Celebrating Annie's birthday", "December 1, 2023", "8:00pm - 10:00pm", $"{receptionAddress}", "Reception", "evadidi@gmail.com");

        Console.WriteLine("------------------------");
        lecture.DisplayShortDescription();
        Console.WriteLine();

        lecture.DisplayStandardDetail();
        Console.WriteLine();

        lecture.DisplayLecture();

        EventAddress address3 = new EventAddress( "Milan's field", "Benin", "Edo", "Nigeria");
        string lectureAddress = address3.GetEventAddress();
        Lectures lecture = new Lectures("Seminary Outdoor Activity", "sport games for seminary student", "December 9, 2023", "12:00pm - 2:00pm", $"{outdoorAddress}", "Outdoor", "sunny");
        Console.WriteLine("------------------------");
        lecture.DisplayShortDescription();
        Console.WriteLine();

        lecture.DisplayStandardDetail();
        Console.WriteLine();

        lecture.DisplayLecture();

    }
}