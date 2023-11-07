using System;

namespace Develop04
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity() : base()
        { 
            SetActivityName("Breathing Activity"); 
            SetdescribBreathe("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        }

        public void RunBreathingActivity()
        {
            RunActivityStart();
            Displayreply();
            RunActivityEnd();
        }

        public void Displayreply()
        {
            int time = GetDuration() * 1000;
            int intervalT = 10000;
            int intervals = time / intervalT;

            for (int i = 0; i < intervals; i++)
            {
                Console.Write("Breathe in...");
                Countup();
                Console.WriteLine();

                Console.Write("breathe out...");
                countdown();
                Console.WriteLine();
            }
        }

        private void countdown()
        {
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        private void Countup()
        {
            for (int i = 1; i <= 5; i++)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    }
}
