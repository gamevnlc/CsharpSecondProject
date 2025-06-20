namespace MySecondProject.SOLID.L;

public class Rectangle: Shape
{
    public virtual double Width { get; set; }
    public virtual double Height { get; set; }
    
    public override double Area => Height * Width;
}
