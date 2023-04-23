using ShapeClass;
using System;
using System.Collections.Generic;

namespace ShapeClass
{
    public class Shape
    {
        public string Color { get; set; }
        public bool Filled { get; set; }
        public Shape()
        {
            Color = "Green";
            Filled = true;
        }
        public string Tostring()
        {
            return $"A Shape with color of {Color} and filled {(Filled ? "filled" : "not filled")}";
        }
    }
}


   


public class ComparableCircle : Circle, IComparable<ComparableCircle>
{
    public ComparableCircle(double radius) : base(radius)
    {
    }

    public ComparableCircle(double radius, string color, bool filled) : base(radius, color, filled)
    {
    }

    public int CompareTo(ComparableCircle other)
    {
        if (other == null) return 1;

        // Compare by area
        return Getarea().CompareTo(other.Getarea());
    }
}


public class Program
{

    static void Main(string[] args)
    {

        var circles = new List<ComparableCircle>
        {
            new ComparableCircle(5.0,"red", true),
            new ComparableCircle(3.0,"indigo", false),

            new ComparableCircle(7.0),
            new ComparableCircle(1.0),
            new ComparableCircle(4.0),
        };

        // In ra danh sách trước khi sắp xếp
        Console.WriteLine("Danh sách trước khi sắp xếp:");
        foreach (var circle2s in circles)
        {
            Console.WriteLine($"Bán kính: {circle2s.Radius}");
        }

        // Sắp xếp danh sách các hình tròn theo bán kính
        circles.Sort();

        // In ra danh sách sau khi sắp xếp
        Console.WriteLine("\nDanh sách sau khi sắp xếp:");
        foreach (ComparableCircle circle2s in circles)
        {
            Console.WriteLine($"Bán kính: {circle2s.Radius}");
        }
        Console.WriteLine("===================================");
        Square square = new Square(5);
        Console.WriteLine(square.ToString());
        Console.WriteLine($"Area={square.Getarea()}, Perimeter={square.GetPerimeter()}");

        Shape shape = new Shape();
        Console.WriteLine(shape.ToString());
        Console.WriteLine("===================================");
        Circle circle = new Circle(5);
        Console.WriteLine(circle.ToString());
        Console.WriteLine($"Area={circle.Getarea()}, Perimeter={circle.GetPerimeter()}");
        Console.WriteLine($"Area={circle.Getarea()}, Perimeter={circle.GetPerimeter()}");

        Console.WriteLine("===================================");
        Rectagular rectangle = new Rectagular(3, 4);
        Console.WriteLine(rectangle.ToString());
       
       
       

    }
}










