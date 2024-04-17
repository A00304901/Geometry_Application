using Geometry_Lib;

public class Triangle : I_shape
{
    public double _side1;
    public double _side2;
    public double _side3;

    public Triangle(double side1, double side2, double side3)
    {
        _side1 = side1;
        _side2 = side2;
        _side3 = side3;
    }

    public double AreaCalculate()
    {
        double s = (_side1 + _side2 + _side3) / 2;
        return Math.Sqrt(s * (s - _side1) * (s - _side2) * (s - _side3));
    }

    public double PerimeterCalculate()
    {
        return _side1 + _side2 + _side3;
    }
}