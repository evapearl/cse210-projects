using System;

public class Menu
{
    public List<Entry> Menu = new List<Entry>();

    public string _filename;


    public List<PromptGenerator> _promptList = new List<PromptGenerator>();
    

    public void Write()
    {
        Console.WriteLine(_promptList.userprompt);
        string userResponse = Console.ReadLine();
        
        string fileName = "myFile.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            OutputFile.WriteLine("write something");
            "myFile.txt" = Console.ReadLine();
        }
        DateTime theCurrentTime = DateTime.Now;

    }

    public void Display()
    {
        Console.WriteLine("Please select one of the following: ");
        foreach (string meni in menu)
        {
            Console.WriteLine(meni);
        }
    }
    
    public void Load()
    {
        Console.WriteLine("What file do you want to load? ");
        "myFile.txt" = Console.ReadLine();
        lines = System.IO.File.ReadAllLines($"myFile.txt");
        foreach (string line in lines)
        {
            parts = line.split(",");
            prompt = parts[0];
        }
    }

    public void Save()
    {
        Console.WriteLine("What is the name of the file? ");
        fileName = Console.ReadLine();
        entri = fileName;
        using (StreamWriter outputFile = new StreamWriter(entri))
        {
            foreach (string entry in entri)
            {
                outputFile.WriteLine($"{_dateTime} >> {_journalList}");
            }
        }
    }

    public void Quit()
    {
        while (userResponse == Quit)
        { 
            Console.WriteLine("Thank you for updating thr program!");
        }
    }
}