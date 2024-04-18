using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometry_Lib;
namespace Geometry_Test_Library;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        double sideLength = 5;
        var Square = new Square(sideLength);
        double result = Square.CalcArea();
        Assert.AreEqual(25, result);
    }

    [TestMethod]
    public void TestSquarePerimeter()
    {
        double sideLength = 5;
        var square = new Square(sideLength);
        double result = square.CalcPerimeter();
        Assert.AreEqual(20, result);
    }
    [TestMethod]
    public void TestSquareArea()
    {
        double sideLength = 5;
        var square = new Square(sideLength);
        double result = square.CalcArea();
        Assert.AreEqual(25, result);
    }

    [TestMethod]
    public void TestSquarePerimeter2()
    {
        double sideLength = 5;
        var square = new Square(sideLength);
        double result = square.CalcPerimeter();
        Assert.AreEqual(20, result);
    }


    [TestMethod]
    public void TestRectangleArea2()
    {
        double length = 5;
        double width = 3;
        var rectangle = new Rectangle(length, width);
        double result = rectangle.CalcArea();
        Assert.AreEqual(15, result);
    }

    [TestMethod]
    public void TestRectanglePerimeter2()
    {
        double length = 5;
        double width = 3;
        var rectangle = new Rectangle(length, width);
        double result = rectangle.CalcPerimeter();
        Assert.AreEqual(16, result);
    }
    [TestMethod]
    public void TestRectangleArea()
    {
        double length = 5;
        double width = 3;
        var rectangle = new Rectangle(length, width);
        double result = rectangle.CalcArea();
        Assert.AreEqual(15, result);
    }

    [TestMethod]
    public void TestRectanglePerimeter()
    {
        double length = 5;
        double width = 3;
        var rectangle = new Rectangle(length, width);
        double result = rectangle.CalcPerimeter();
        Assert.AreEqual(16, result);
    }


        
    [TestMethod]
    public void TestTrianglePerimeter1()
    {
        double side1 = 5;
        double side2 = 6;
        double side3 = 7;
        var triangle = new Triangle(side1, side2, side3);
        double result = triangle.PerimeterCalculate();
        Assert.AreEqual(18, result);
    }
    [TestMethod]
        public void TestTrianglePerimeter2()
    {
        double side1 = 3;
        double side2 = 4;
        double side3 = 5;
        var triangle = new Triangle(side1, side2, side3);
        double result = triangle.PerimeterCalculate();
        Assert.AreEqual(12, result);
    }
    [TestMethod]
    public void TestTriangleArea3()
    {
        double side = 5;
        var triangle = new Triangle(side, side, side);
        double result = triangle.AreaCalculate();
        Assert.AreEqual(10.825317547305485, result, 0.0001);
    }

    [TestMethod]
    public void TestTrianglePerimeter4()
    {
        double side = 5;
        var triangle = new Triangle(side, side, side);
        double result = triangle.PerimeterCalculate();
        Assert.AreEqual(15, result);
    }

    [TestMethod]
    public void TestTriangleArea5()
    {
        double side1 = 3;
        double side2 = 4;
        double side3 = 5;
        var triangle = new Triangle(side1, side2, side3);
        double result = triangle.AreaCalculate();
        Assert.AreEqual(6, result);
    }
}
    