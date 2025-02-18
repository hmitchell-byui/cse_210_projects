using System.Security.Cryptography;

public class Circle : Shape
{
    private double _radius = 0;
    double _pi = 3.14159;
    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }
    // public double GetRadius()
    // {
    //     return _radius;
    // }
    // public void SetRadius(double radius)
    // {
    //     _radius = radius;
    // }
    public override double GetArea()
    {
        _area = _radius * Math.Pow(_pi, 2);
        return _area;
    }
}