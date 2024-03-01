﻿public class Triangle : IShape
{
    public double Base { get; set; }
    public double Height { get; set; }

    public Triangle(double @base, double height)
    {
        Base = @base;
        Height = height;
    }

    public double CalculateArea()
    {
        return 0.5 * Base * Height;
    }
}
