using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        IShape[] shapes = new IShape[]
        {
            new Rectangle(5, 4),
            new Circle(3),
            new Triangle(6, 8),
            new Trapezoid(4, 6, 5)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Area: {shape.CalculateArea()}");
        }
    }
}
