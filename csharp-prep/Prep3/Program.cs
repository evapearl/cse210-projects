using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int number = int.Parse(Console.ReadLine());

        Console.Write('What is your guess? ');
        string guess = Console.ReadLine();
        int guess = int.Parse(guess);

        while (guess != "magicNo")
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine())

            if (magicNo > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNo < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed the it!");
            }   
        }
    }
}