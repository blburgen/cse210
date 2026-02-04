using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string runProgram = "0";
        while(runProgram != "4"){
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            runProgram = Console.ReadLine();

            if(runProgram == "1")
            {
                BreathingActivity breath = new BreathingActivity();
                breath.Run();
            }
            else if(runProgram == "2"){
                
            }
            else if(runProgram == "3")
            {
                
            }
            else if(runProgram == "4")
            {
                Console.WriteLine("Have a good day");
            }
            else
            {
               Console.WriteLine("Not a valid option, press Enter to continue");
               Console.ReadLine(); 
            }
        }
    }
}