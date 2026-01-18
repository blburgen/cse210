// Author: Brady Burgener
// Things I did above the requirements:
//  Allowed the user to quit out of load if it was not wanted
//  Added option to save and quit
//  Allowed the user to add current entries to loading file


using System;
using System.Transactions;

class Program
{
    
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();

        PromptGenerator prompt = new PromptGenerator();
        Entry currentEntry = new Entry();
        currentEntry.Display();
        string currentfile = null;

        string menuresponse = "";
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Welcome to the Journal Program!");
        while (menuresponse != "5"){
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a Entry");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("6. Save and Quit");
            Console.Write("What would you like to do(1-5)? ");
            menuresponse = Console.ReadLine().Trim();
            Console.WriteLine();
            if(menuresponse == "1")
            {
                string prompt_current =prompt.GetRandomPromt();
                Console.WriteLine("Your Journal Prompt:");
                Console.WriteLine(prompt_current);
                Console.Write("Your Entry: ");
                string user_input = Console.ReadLine();
                myJournal.AddEntry(DateOnly.FromDateTime(DateTime.Now).ToString(),prompt_current,user_input);
            }
            else if(menuresponse == "2")
            {
                Console.WriteLine("Date -- Prompt -- Your Entry");
                myJournal.DisplayAll();
            }
            else if(menuresponse == "3")
            {
                List<Entry> tempJournal = [];
                Console.Write("Would you like to add current entries to end of loaded journal (Y/N)? ");
                string addtest = Console.ReadLine();
                if(addtest.ToLower() == "y")
                {
                    tempJournal = new List<Entry>(myJournal.CopyList());
                }
                Console.Write("What .txt file would you like to open (type q to cancel)? ");
                string test = Console.ReadLine();
                if (test.ToLower() != "q")
                {
                    currentfile = test;
                    myJournal.LoadFromFile(currentfile); 
                }
                if (tempJournal.Count > 0)
                {
                    foreach(Entry j in tempJournal)
                    {
                        myJournal.AddEntry(j._date, j._promptText, j._entryText);
                    }
                }
                
            }
            else if(menuresponse == "4")
            {
                currentfile = SaveFile(currentfile, myJournal);
            }
            else if(menuresponse == "5")
            {
                quitprogram();
            }
            else if(menuresponse == "6")
            {
                currentfile = SaveFile(currentfile, myJournal);
                quitprogram();
                menuresponse = "5";
            }
            else
            {
                Console.WriteLine("That was not a valid input.  Please choose a number between 1 and 5.");
            }
            
        }

        

    }

    static void quitprogram()
    {
        Console.WriteLine();
        Console.WriteLine("Have a good day!");
        Console.WriteLine("Good Bye!");
        Console.WriteLine();
    }

    static string SaveFile(string currentfile, Journal myJournal)
    {
        if(currentfile != null)
            {
                Console.Write($"Would you like to save to the current ({currentfile}) file(Y/N)? ");
                string yesNo = Console.ReadLine();
                if (yesNo.ToLower() == "n")
                {
                    Console.Write("What name would you like for you .txt file? ");
                    currentfile = Console.ReadLine();
                } 
                else if (!(yesNo.ToLower() == "n" || yesNo.ToLower() == "y" || yesNo.ToLower() == ""))
                {
                    Console.Write("Not a valid answer");
                    Console.Write("What name would you like for you .txt file? ");
                    currentfile = Console.ReadLine();
                }
            }
            else
            {
                Console.Write("What name would you like for you .txt file? ");
                currentfile = Console.ReadLine();
            }
            myJournal.SaveToFile("myfile");
        return currentfile;
    }
    
}