using ShapeClass;
using System;

public class Circle : Shape
{
    public double Radius;



    public Circle(double radius)
    {
        Radius = radius;
    }

    public Circle(double radius, string color, bool filled) : this(radius)
    {
    }

    public double Getarea()
    {
        return Math.PI * Radius * Radius;
    }
    public double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }
    public virtual string ToString()
    {
        return $"A Circle with radius={Radius}, which is a subclass of {base.ToString()}";
    }
}