using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation1 World!");

        List<Video> videosList = new List<Video>();

        Video video1 = new Video();
        video1._title = "Plug";
        video1._length = "180";
        video1._author = "Ivan Jack";

        Comment video1Comment1 = new Comment();
        video1Comment1._name = "Ese Joyce";
        video1Comment1._commentTxt = "The song is so inspiring";

        Comment video1Comment2 = new Comment();
        video1Comment2._name = "Jones Randy";
        video1Comment2._commentTxt = "I love the beats";

        Comment video1Comment3 = new Comment();
        video1Comment3._name = "Mirabel Osas";
        video1Comment3._commentTxt = "I watch it every evening";

        
        Video video2 = new Video();
        video2._title = "Sweet Cry";
        video2._length = "210";
        video2._author = "Jerry Owen";

        Comment video2Comment1 = new Comment();
        video2Comment1._name = "Muran Efik";
        video2Comment1._commentTxt = "it's so emotional";

        Comment video2Comment2 = new Comment();
        video2Comment2._name = "Wilpower F";
        video2Comment2._commentTxt = "Sometimes it is okay to sad";

        Comment video2Comment3 = new Comment();
        video2Comment3._name = "musiclovElla";
        video2Comment3._commentTxt = "I watch it when I feel down";


        Video video3 = new Video();
        video3._title = "Grateful";
        video3._length = "200";
        video3._author = "Amanda Smith";

        Comment video3Comment1 = new Comment();
        video3Comment1._name = "Louis Vicky";
        video3Comment1._commentTxt = "I'm grateful for His redeeming grace";

        Comment video3Comment2 = new Comment();
        video3Comment2._name = "Eric Daye";
        video3Comment2._commentTxt = "I love this song. It helps me think of my Savior.";

        Comment video3Comment3 = new Comment();
        video3Comment3._name = "Montra Peggy";
        video3Comment3._commentTxt = "Thank you so much for this song!";

        video1._commentList.Add(video1Comment1);
        video1._commentList.Add(video1Comment2);
        video1._commentList.Add(video1Comment3);

        video2._commentList.Add(video1Comment1);
        video2._commentList.Add(video1Comment2);
        video2._commentList.Add(video1Comment3);

        video3._commentList.Add(video1Comment1);
        video3._commentList.Add(video1Comment2);
        video3._commentList.Add(video1Comment3);

        videosList.Add(video1);
        videosList.Add(video2);
        videosList.Add(video3);

        foreach(Video video in videosList)
        {
            video.DisplayVideoDetails();
            Console.WriteLine();
        }
    }
}