using System;

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string Colour, double width) : base (colour)
    {
        _length = length;
        _width = width;
    }
    public override double GetArea()
    {
        return _length * _width;
    }
}