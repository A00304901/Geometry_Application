using System;
using Geometry_Lib;
namespace Geometry_Lib;


public class Rectangle : I_shape
{
    public double _length;
    public double _width;

    public Rectangle(double length, double width)
    {
        _length = length;
        _width = width;
    }

    public double CalcArea()
    {
        return _length * _width;
    }

    public double CalcPerimeter()
    {
        return 2 * (_length + _width);
    }
}