using System;
namespace Develop04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Hope you enjoy your time here");
            Console.WriteLine();
            run = true;
            while (run)
            {
                Console.WriteLine("Menu Options:");
                Console.WriteLine(" 1. Breathing Activity");
                Console.WriteLine(" 2. Reflecting Activity");
                Console.WriteLine(" 3. Listing Activity");
                Console.WriteLine(" 4. Quit");
                Console.WriteLine();

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        BreathingActivity B = new BreathingActivity();
                        B.RunBreathingActivity();
                        break;

                    case 2 :
                        Console.Clear();
                        ReflectingActivity R = new ReflectingActivity();
                        R.RunReflectingActivity();
                        break;

                    case 3 :
                        Console.Clear();
                        ListingActivity L = new ListingActivity();
                        L.RunListingActivity();
                        break;

                    case 4 :
                        run = false;
                        Console.WriteLine("Thank you. Hope you enjoyed your time? ");
                        string input = Console.ReadLine();
                        if (input == "no")
                        {
                            Console.WriteLine("It will be better on your next try.");
                        }

                        else
                        {
                            Console.WriteLine("Great!");
                        }
                        break;
                    
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }

            }
        }
    }
}