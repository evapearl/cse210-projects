using System;

namespace Develop04
{ 
    public class Activity
    {
        private string _startMessage;
        private int _duration = 0 ;
        private int _spinnerC = 0;
        private string _activityName;
        private string _endMessage;
        private string _activityDescription;

        public Activity()
        {
            _spinnerC = _duration;
        }
        public void SetActivityName(string activityName)
        {
            _activityName = activityName;
        }

        public void SetActivityDescription(string activityDescription)
        {
            _activityDescription = activityDescription;
        }

        public void DisplayStartMessage()
        {
            _startMessage = $"Welcome to the {_activityName}.";
            Console.WriteLine(_startMessage);
            Console.WriteLine();
        }

        public int GetDuration()
        {
            return _duration;
        }

        public void DisplayDescription()
        {
            Console.WriteLine(_activityDescription);
            Console.WriteLine();
        }

        public void DisplaySpinner(int seconds)
        {
            Thread spinner = new Thread();

            spinner.Start();

            //int _spinnerC = 0;

            while (Elaspemilliseconds / 1000 < seconds)
            {
                _spinnerC++;
                switch (_spinnerC % 4)
                {
                    case 0: Console.Write("/");
                        break;
                    case 1: Console.Write("-");
                        break;
                    case 2: Console.Write("\\");
                        break;
                    case 3: Console.Write("|");
                        break;
                }
                Thread.Sleep(200);
            }
            Console.Write(" ");
        }
        public void DisplayCountDown(int seconds)
        {
            for (int i = seconds; i >= 1; i--)
            {
                Console.Write($"You may begin in {i}");
                Console.SetCursorPosition(0, Console.CursorTop);
                Thread.Sleep(1000);
            }
        }

        public void DisplayGetDuration()
        {
            Console.Write("How many seconds do you want to play the activity? ");
            _duration = int.Parse(Console.ReadLine());
        }
        public void DisplayGetReady()
        {
            Console.WriteLine("Get reay...");
            DisplaySpinner(5);
        }

        public void DisplayEndMessage()
        { 
            _endMessage = $"You have completed {_activityName}.";
            Console.WriteLine();
            Console.WriteLine("Well done!");
            DisplaySpinner(5);
            Console.WriteLine();
            Console.WriteLine(_endMessage);
            DisplaySpinner(5);
            Console.Clear();
        }
        public void RunActivityStart()
        {
            DisplayStartMessage();
            DisplayDescription();
            DisplayGetDuration();
            DisplayGetReady();
            Console.Clear();
        }
        public void RunActivityEnd()
        {
            DisplayEndMessage();
        }       
    }
}