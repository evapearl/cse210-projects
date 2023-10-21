using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture script = new Scripture ("1 Thessalonians", 4, 7, "For God hath not call us unto uncleanness, but unto holiness.");
        console.Clear();
        console.WriteLine("Press Enter to continue or type 'quit' to end programe");

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
            console.Clear();
            Scripture.Display();
            console.WriteLine("Press Enter to continue or type 'quit' to end programe");
            
        }
    }
}