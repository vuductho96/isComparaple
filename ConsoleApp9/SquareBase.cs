using ShapeClass;
public class Square : Rectagular
{
    public Square(double side) : base(side, side)
    {
    }

    public override string ToString()
    {
        return $"A Square with side={Width}, which is a subclass of {base.ToString()}";
    }
    public double GetArea()
    {
        return Width * Width;
    }

    public double GetPerimeter()
    {
        return 4 * Width;
    }
}