using System;

class Program
{
    static void Main(string[] args)
    {
        Entry choice1 = new Choice();
        choice1._idNumber = 1;
        choice1._journalList = "Write" ;

        
        Entry choice2 = new Choice();
        choice2._idNumber = 2;
        choice2._journalList = "Display";


        Entry choice3 = new Choice();
        choice3._idNumber = 3;
        choice3._journalList = "Load";


        Entry choice4 = new Choice();
        choice4._idNumber = 4;
        choice4._journalList = "Save" ;


        Entry choice5 = new Choice();
        choice5._idNumber = 5;
        choice5._journalList = "Quit" ;

        Menu menulist = new Menu();
        menulist.write().Add(choice1);
        menulist.write().Add(prompt);

        menulist.Display().Add(choice2);

        menulist.Load().Add(choice3);

        menulist.Save().Add(choice4);

        menulist.Quit().Add(choice5);


        PromptGenerator prompt = new Prompt();
        prompt._promptList = "userprompt";

        menulist.Display();
    }
}