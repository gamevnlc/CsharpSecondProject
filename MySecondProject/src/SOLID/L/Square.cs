namespace MySecondProject.SOLID.L;

// public class Square:Rectangle
public class Square:Shape
{
    // public override double Width
    // {
    //     get => base.Width;
    //     set => base.Width = base.Height =  value;
    // }
    //
    // public override double Height
    // {
    //     get => base.Height;
    //     set => base.Height = base.Width = value;
    // }
    public double SideLength { get; set; }
    public override double Area => SideLength * SideLength;
}