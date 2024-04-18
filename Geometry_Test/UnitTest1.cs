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

            // Act
            double result = Square.CalcArea();

            // Assert
            Assert.AreEqual(25, result);
    }

    [TestMethod]
    public void TestSquarePerimeter()
    {
        // Arrange
        double sideLength = 5;
        var square = new Square(sideLength);

        // Act
        double result = square.CalcPerimeter();

        // Assert
        Assert.AreEqual(20, result);
        }

    [TestMethod]
    public void TestRectangleArea()
    {
        // Arrange
        double length = 5;
        double width = 3;
        var rectangle = new Rectangle(length, width);

        // Act
        double result = rectangle.CalcArea();

        // Assert
        Assert.AreEqual(15, result);
    }

        [TestMethod]
        public void TestRectanglePerimeter()
        {
            // Arrange
            double length = 5;
            double width = 3;
            var rectangle = new Rectangle(length, width);

            // Act
            double result = rectangle.CalcPerimeter();

            // Assert
            Assert.AreEqual(16, result);
        }

        [TestMethod]
        public void TestTriangleArea()
        {
            // Arrange
            double side1 = 5;
            double side2 = 6;
            double side3 = 7;
            var triangle = new Triangle(side1, side2, side3);

            // Act
            double result = triangle.AreaCalculate();

            // Assert
            Assert.AreEqual(14.696938456699069, result, 0.0001);
        }

        [TestMethod]
        public void TestTrianglePerimeter()
        {
            // Arrange
            double side1 = 5;
            double side2 = 6;
            double side3 = 7;
            var triangle = new Triangle(side1, side2, side3);

            // Act
            double result = triangle.PerimeterCalculate();

            // Assert
            Assert.AreEqual(18, result);
        }
}
    