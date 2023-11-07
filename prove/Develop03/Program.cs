using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture script = new scripture ("1 Thessalonians", 4, 7, "For God hath not call us unto uncleanness, but unto holiness.");
        Console.Clear();
        Console.WriteLine("Press Enter to continue or type 'quit' to end programe");

        while (true)
        {
            string reply = console.ReadLine();
            if (reply.Tolower() == "quit") {
                break;
            }
            else if (!Scripture.HideRandomWord()) {
                console.WriteLine("You got it right, well done!");
                break;
            }
            Console.Clear();
            Scripture.Display();
            Console.WriteLine("Press Enter to continue or type 'quit' to end programe");
            
        }
    }
}