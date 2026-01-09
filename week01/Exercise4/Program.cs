using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
            
        }
        float total = 0;
        int largest = 0;
        int smallest = 0;
        foreach (int item in numbers)
        {
            total += item;
            if (item > largest)
            {
                largest = item;
            }
            if (item > 0 && (item < smallest || smallest == 0))
            {
                smallest = item;
            }
        }

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {total / numbers.Count}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }

    }
}