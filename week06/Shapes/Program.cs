// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//     Console.WriteLine("Hello World! This is the Shapes Project.");
//     public List<Shape> shapes = new List<Shape>();
//     Square s1 = new Square("red", 3);
//     shapes.Add(s1);

//     Rectangle r1 = new Rectangle(6, 2, "blue");
//     shapes.Add(r1);

//     Circle c1 = new Circle(5, "Orange");
//     shapes.Add(c1);

//     foreach (Shape s in shapes)
//     {
//         string color = s.GetColor();
//         double area = s.GetArea();

//         Console.WriteLine($"The {color} {s} has an area of {area}.");

//     }
//     }
// }
using System;

class Program
{
    static void Main(string[] args)
    {
        // Notice that the list is a list of "Shape" objects. That means
        // you can put any Shape objects in there, and also, any object where
        // the class inherits from Shape
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle(5, 4, "Blue");
        shapes.Add(s2);

        Circle s3 = new Circle(6, "Green");
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            // Notice that all shapes have a GetColor method from the base class
            string color = s.GetColor();

            // Notice that all shapes have a GetArea method, but the behavior is
            // different for each type of shape
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}