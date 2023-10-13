using System;

using System.Collec
{
    
}

using System.IO;

public class Menu
{
    public List<Entry> menu = new List<Entry>();

    public string _filename;


    public List<PromptGenerator> _promptList = new List<PromptGenerator>();
    

    public void write()
    {
        console.writeLine(_promptList.userprompt);
        string userResponse = console.ReadLine();
        
        string fileName = "myFile.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            OutputFile.writeLine("write something");
            "myFile.txt" = console.ReadLine();
        }
        DateTime theCurrentTime = DateTime.Now;

    }

    public void Display()
    {
        console.writeLine("Please select one of the following: ");
        foreach (string meni in menu)
        {
            console.writeLine(meni);
        }
    }
    
    public void Load()
    {
        console.writeLine("What file do you want to load? ");
        "myFile.txt" = console.ReadLine();
        lines = System.IO.File.ReadAllLines($"myFile.txt");
        foreach (string line in lines)
        {
            parts = line.split(",");
            prompt = parts[0];
        }
    }

    public void Save()
    {
        console.writeLine("What is the name of the file? ");
        fileName = console.ReadLine();
        entri = fileName;
        using (StreamWriter outputFile = new StreamWriter(entri))
        {
            foreach (string entry in entri)
            {
                outputFile.writeLine($"{_dateTime} >> {_journalList}");
            }
        }
    }

    public void quit()
    {
        while (userResponse == Quit)
        { 
            console.writeLine("Thank you for updating thr program!");
        }
    }
}