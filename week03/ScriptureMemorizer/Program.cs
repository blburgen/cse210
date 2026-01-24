using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        bool exit = false;
        Reference newreference = new Reference("Proverbs",3,5,6);
        string scripture = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
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