using Geometry_Lib;

public class Square : I_shape
{
    public double _sideLength;

    public Square(double sideLength)
    {
        _sideLength = sideLength;
    }

    public double CalcArea()
    {
        return _sideLength * _sideLength;
    }

    public double CalcPerimeter()
    {
        return 4 * _sideLength;
    }
}