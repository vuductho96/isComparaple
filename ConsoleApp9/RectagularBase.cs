using ShapeClass;
public class Rectagular : Shape
{

    public double Width { get; set; }
    public double Length { get; set; }
    public Rectagular(double width, double length)
    {
        this.Width = width;
        this.Length = length;
    }
    public double Getarea()
    {
        return Width * Length;
    }
    public double GetPerimeter()
    {
        return 2 * (Width + Length);

    }
    public override string ToString()
    {
        return $"A Rectangle with width={Width} and length={Length}, which is a subclass of {base.ToString()}";
    }

}