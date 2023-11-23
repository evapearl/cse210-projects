using System;

namespace Develop04
{
    public class ReflectingActivity : Activity
    {
        private List <string> _promptReflects;
        private List <string> _reflects;
        private string _activityName;
        private string _describReflect;


        public ReflectingActivity(string activityName, string describReflect, int ): base()
        {
            _activityName = activityName;
            _describReflect = describReflect;
            GetActivityName("Reflection Activity");
            GetDescribReflect("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        
        }

            _promptReflects = new List<string>
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };

            _reflects = new List<string>
            {
                "Think of a time when you stood up for someone else",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };
        }

        public void RunReflectingActivity()
        {
            RunActivityStart();
            DisplayPromptR();
            DispayPromptReflects();
            RunActivityEnd();
        }

        public void DisplayPromptR()
        {
            Console.WriteLine("Consider the following: ");
            Console.WriteLine();

            int randomindex = new Random().Next(0, _reflects.Count());
            Console.WriteLine(_reflects[randomindex]);
            Console.WriteLine();

            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();
        }
        public void DispayPromptReflects()
        { 
            List<int> indexes= new List <int>();
            for (int i = 0; i < 4; i++)
            {
                int randomInt = new Random().Next(0, _promptReflects.Count());
                while (indexes.Contains(randomInt))
                {
                    randomInt = new Random().Next(0, _promptReflects.Count());
                }
                indexes.Add(randomInt);
            }
            Console.Clear();
            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
            Console.WriteLine();
            DisplayCountDown(5);

            foreach (int index in indexes)
            {
                Console.Write(_promptReflects[index]);
                DisplaySpinner(GetDuration() / indexes.Count());
                Console.WriteLine();
            }
        }
    }
}