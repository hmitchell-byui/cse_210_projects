using System.Reflection.Metadata.Ecma335;

public class Square : Shape
{
    private double _side;
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }
    // public double GetSide()
    // {
    //     return _side;
    // }
    // public void SetSide(double side)
    // { 
    //     _side = side;
    // }
    public override double GetArea()
    {
        _area = Math.Pow(_side, 2);
        return _area;
    }
}