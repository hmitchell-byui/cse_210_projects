using System.Drawing;

public abstract class Shape
{
    protected string _color = "";
    protected double _area = 0;
    public Shape(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public abstract double GetArea();

}