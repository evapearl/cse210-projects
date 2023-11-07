using System;

namespace Develop04
{
    public class ListingActivity : Activity
    {
        private List <string> _promptList;
        private string _randomp {get; set;}

        public ListingActivity(): base()
        {
            SetActivityName("Listing Activity");
            SetActivityDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

            _promptList = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };
        }

        public void RunListingActivity()
        {
            RunActivityStart();
            ListingCount();
            RunActivityEnd();
        }
        private void DisplayPromptList()
        {
            Console.WriteLine("L");
            Console.WriteLine();
            int randomindex = new Random.Next(0, _promptList.Count());
            Console.WriteLine(_promptList[randomindex]);
            Console.WriteLine();
        }
        
        public void ListingCount()
        {
            DateTime startTime = Date.Now;
            DateTime futureTime = startTime.AddSeconds(GetDuration());
            DateTime CurrentTime = DateTime.Now;
            int count = 0;
            while (CurrentTime < futureTime)
            {
                Console.Write("We are still behind the time ");
                Console.ReadLine();
                count += 1;
                CurrentTime = DateTime.Now;
            }
            Console.WriteLine();
            Console.WriteLine($"You listed {count} items.");
            DisplaySpinner(5);
        }
    }
}