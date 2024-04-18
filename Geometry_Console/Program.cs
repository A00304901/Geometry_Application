using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.FeatureManagement;
using Geometry_Lib;

var featureManagement = new Dictionary<string, string> {{ "FeatureManagement:Square", "true"}, { "FeatureManagement:Rectangle", "true"}, { "FeatureManagement:Triangle", "false"}};

IConfigurationRoot configuration = new ConfigurationBuilder().AddInMemoryCollection(featureManagement).Build();

var services = new ServiceCollection();
services.AddFeatureManagement(configuration);
var serviceProvider = services.BuildServiceProvider();

var featureManager = serviceProvider.GetRequiredService<IFeatureManager>();
    if (await featureManager.IsEnabledAsync("Square"))
    {
        // Provide access to Square
        Console.WriteLine("Enter the side length of the square:");
            double sideLength = Convert.ToDouble(Console.ReadLine());

            Square square = new Square(sideLength);
            double area = square.CalcArea();
            double perimeter = square.CalcPerimeter();

            Console.WriteLine($"Area of the square: {area}");
            Console.WriteLine($"Perimeter of the square: {perimeter}");
    }
    else
    {
        Console.WriteLine($"Wrong Input");
    }
    

    if (await featureManager.IsEnabledAsync("Rectangle"))
    {
        // provide access to Rectangle
        Console.WriteLine("Enter the length of the rectangle:");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle:");
            double width = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(length, width);

            double area = rectangle.CalcArea();
            double perimeter = rectangle.CalculPerimeter();

            Console.WriteLine($"Area of the rectangle: {area}");
            Console.WriteLine($"Perimeter of the rectangle: {perimeter}");
    
    }
    else
    {
        Console.WriteLine($"Wrong Input");

    }


    if (await featureManager.IsEnabledAsync("Triangle"))
    {   
        //provide access to Triangle

       Console.WriteLine("Enter the first side of the triangle:");
            double side1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second side of the triangle:");
            double side2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third side of the triangle:");
            double side3 = double.Parse(Console.ReadLine());

            Triangle triangle = new Triangle(side1, side2, side3);

            double area = triangle.AreaCalculate();
            double perimeter = triangle.PerimeterCalculate();

            Console.WriteLine($"Area of the triangle: {area}");
            Console.WriteLine($"Perimeter of the triangle: {perimeter}");

    }
    else
    {
        Console.WriteLine($"Wrong Input");
    }
    