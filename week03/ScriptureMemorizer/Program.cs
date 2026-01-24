//  I exceeded requirements by loading the scripture from a file.
//  In the file I have scripture it is randomly choosen from.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        bool exit = false;
        LoadScripture file = new LoadScripture("MyScripture.txt");
        List<string> line = file.RandomScripture();
        Reference newreference;
        string scripture;
        if(line.Count == 5)
        {
            newreference = new Reference(line[0],int.Parse(line[1]),int.Parse(line[2]),int.Parse(line[3]));
            scripture = line[4];
        }
        else
        {
            newreference = new Reference(line[0],int.Parse(line[1]),int.Parse(line[2]));
            scripture = line[3];

        }
        // string scripture = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture current = new Scripture(newreference,scripture);
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine(current.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string quit = Console.ReadLine();
            if (quit.ToLower() == "quit" || current.IsCompletelyHidden()){
                exit = true;
            }
            current.HideRandomWords(3);
        }
        
    }
}