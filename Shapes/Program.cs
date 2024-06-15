using System;
using Shapes;

class Program
{
    static void Main(string[] args)
    {
        // Create a Circle instance
        Circle circle = new Circle(5);
        Console.WriteLine($"Radius of the Circle: {circle.Radius}");
        double circleArea = circle.GetArea();
        Console.WriteLine($"Area of the Circle: {circleArea}");
       

        // Create a Rectangle instance
        Rectangle rectangle = new Rectangle(15, 6);
        Console.WriteLine($"Width of the Rectangle: {rectangle.Width}");
        Console.WriteLine($"Height of the Rectangle: {rectangle.Height}");
        double rectangleArea = rectangle.GetArea();
        Console.WriteLine($"Area of the Rectangle: {rectangleArea}");
    }
}
