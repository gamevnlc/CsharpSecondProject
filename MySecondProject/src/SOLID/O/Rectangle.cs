namespace MySecondProject.SOLID.O;

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Length { get; set; }

    public override double CalculateArea()
    {
        return Length * Width;
    }
}