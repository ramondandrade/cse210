using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        // Individual tests
        Square square = new Square("Red", 4);
        Console.WriteLine($"Square - Color: {square.GetColor()}, Area: {square.GetArea()}");

        Rectangle rectangle = new Rectangle("Blue", 5, 3);
        Console.WriteLine($"Rectangle - Color: {rectangle.GetColor()}, Area: {rectangle.GetArea()}");

        Circle circle = new Circle("Green", 2.5);
        Console.WriteLine($"Circle - Color: {circle.GetColor()}, Area: {circle.GetArea()}");

        // List of shapes
        List<Shape> shapes = new List<Shape>
        {
            square,
            rectangle,
            circle
        };

        Console.WriteLine("\nList of Shapes:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea():F2}");
        }
    }
}