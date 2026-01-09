using System;

class Program
{
    static void Main(string[] args)
    {
        string play = "y";

        while (play.ToLower() == "y" || play.ToLower() == "yes" )
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);

            int guess = -1;
            int times = 0;

            while (guess != number)
            {
                Console.Write("What is the magic number? ");
                guess = int.Parse(Console.ReadLine());

                times ++;

                if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.WriteLine($"It took you {times} guesses to get the number.");
            Console.Write("Would you like to play again (Y/N)? ");
            play = Console.ReadLine();
        }
    }
}