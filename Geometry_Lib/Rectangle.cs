using System;
using Geometry_Lib;


public class Rectangle : I_shape
{
    public double _length;
    public double _width;

    public Rectangle(double length, double width)
    {
        _length = length;
        _width = width;
    }

    public double CalculArea()
    {
        return _length * _width;
    }

    public double CalculPerimeter()
    {
        return 2 * (_length + _width);
    }
}