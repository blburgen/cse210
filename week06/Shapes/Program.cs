using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(2,"blue");
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square(3, "Red");
        shapes.Add(s1);

        Rectangle s2 = new Rectangle(4, 5, "Blue");
        shapes.Add(s2);

        Circle s3 = new Circle(6, "Green");
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}