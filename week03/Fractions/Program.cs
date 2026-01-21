using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Fraction first = new Fraction();
        Console.WriteLine($"{first.GetTop()} - {first.GetBottom()}");
        Fraction second = new Fraction(6);
        Console.WriteLine($"{second.GetTop()} - {second.GetBottom()}");
        Fraction third = new Fraction(6,7);
        Console.WriteLine($"{third.GetTop()} - {third.GetBottom()}");

        first.SetTop(4);
        first.SetBottom(5);
        Console.WriteLine($"{first.GetTop()} - {first.GetBottom()}");
        Console.WriteLine(first.GetFractionString());
        Console.WriteLine(first.GetDecimalValue());
        Console.WriteLine(second.GetFractionString());
        Console.WriteLine(second.GetDecimalValue());
        Console.WriteLine(third.GetFractionString());
        Console.WriteLine(third.GetDecimalValue());

        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}