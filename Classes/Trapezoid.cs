public class Trapezoid : IShape
{
    public double Base1 { get; set; }
    public double Base2 { get; set; }
    public double Height { get; set; }

    public Trapezoid(double base1, double base2, double height)
    {
        Base1 = base1;
        Base2 = base2;
        Height = height;
    }

    public double CalculateArea()
    {
        return 0.5 * (Base1 + Base2) * Height;
    }
}
