using System;

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
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do(1-5)? ");
            menuresponse = Console.ReadLine().Trim();
            if(menuresponse == "1")
            {
                
            }
            else if(menuresponse == "2")
            {
                
            }
            else if(menuresponse == "3")
            {
                
            }
            else if(menuresponse == "4")
            {
                if(currentfile != null)
                {
                   Console.Write("Would you like to save to current file(Y/N)? ");
                   string yesNo = Console.ReadLine();
                   if (yesNo.ToLower() == "n")
                    {
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
            }
            else if(menuresponse == "5")
            {
               Console.WriteLine("Have a good day!");
               Console.WriteLine("Good Bye!");
            }
            else
            {
                Console.WriteLine("That was not a valid input.  Please choose a number between 1 and 5.");
            }

            // string current_prompt = prompt.GetRandomPromt();

            // Console.WriteLine(current_prompt);
            
        }
        myJournal.LoadFromFile("myfile");
        myJournal.AddEntry(DateTime.Now.ToString(),prompt.GetRandomPromt(),"di");
        myJournal.DisplayAll();
        myJournal.SaveToFile("myfile");

    }
}