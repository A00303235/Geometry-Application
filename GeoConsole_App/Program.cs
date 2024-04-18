using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.FeatureManagement;
using GeoClass_Lib;



var featureManagement = new Dictionary<string, string> {{"FeatureManagement:Square", "true"}, 
{ "FeatureManagement:Rectangle", "true"}, { "FeatureManagement:Triangle", "true"}};

IConfigurationRoot configuration = new ConfigurationBuilder().AddInMemoryCollection(featureManagement).Build();

var services = new ServiceCollection();
services.AddFeatureManagement(configuration);
var serviceProvider = services.BuildServiceProvider();


var featureManager = serviceProvider.GetRequiredService<IFeatureManager>();


if (await featureManager.IsEnabledAsync("Square"))
    {
        Console.WriteLine("Enter the side length of the square:");
        double sideLength = double.Parse(Console.ReadLine());
        Square square = new Square(sideLength);

        double area = square.Area();
        double perimeter = square.Perimeter();

        Console.WriteLine($"Area of the square: {area}");
        Console.WriteLine($"Perimeter of the square: {perimeter}");
    }
else                              
    {
        Console.WriteLine("Square feature is not enabled in your workspace.");
    }

if (await featureManager.IsEnabledAsync("Rectangle"))
    {
     Console.WriteLine("Enter the length of the rectangle:");
                var Length = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the width of the rectangle:");
                var Width = double.Parse(Console.ReadLine());


                Rectangle rectangle = new Rectangle( Length,  Width);

                Console.WriteLine($"Rectangle Area: {rectangle.Area()}");
                Console.WriteLine($"Rectangle Perimeter: {rectangle.Perimeter()}");
    }
else                              
    {
        Console.WriteLine("Rectangle feature is not enabled in your workspace.");
    }

if (await featureManager.IsEnabledAsync("Triangle"))
    {
        Console.WriteLine("Enter the base of the triangle:");
        double bottomLenght = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height of the triangle:");
        double length = double.Parse(Console.ReadLine());
        var triangle = new Triangle { Bottom = bottomLenght, Length = length};
        Console.WriteLine($"Triangle Area: {triangle.Area()}, Perimeter: {triangle.Perimeter()}");
    }
else                              
    {
        Console.WriteLine("Triangle feature is not enabled in your workspace.");
    }