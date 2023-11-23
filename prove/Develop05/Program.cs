using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput = 0;
        GoalManager goalManager = new GoalManager();

        List <string> menu = new List<string>
        {
            "Main Menu",
            "Please select one of the following options:",
            "1. List Goals",
            "2. Save Goals",
            "3. Load Goals",
            "4. Record Goal",
            "5. Quit "
        };

        while (userInput != 6)
        {
            Console.WriteLine();
            foreach (string mmenu in menu)
            {
                Console.WriteLine(mmenu);
            }
            Console.Write("Select a choice from the menu: ");
            userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                goalManager.ListGoal();
                    break;

                case 2:
                goalManager.SaveGoals();
                    break;

                case 3:
                goalManager.LoadGoal();
                    break;

                case 4:
                goalManager.RecordGoalEvent();
                    break;
            }
        }
            
    }
}