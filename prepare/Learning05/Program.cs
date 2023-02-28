using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!\n");
        Square square = new Square(4, "Red");
        Rectangle rectangle = new Rectangle(8, 5, "Green");
        Circle circle = new Circle(7, "Orange-Red");

        List<Shape> _shapeAreas = new List<Shape>();
        _shapeAreas.Add(square);
        _shapeAreas.Add(rectangle);
        _shapeAreas.Add(circle);

        foreach (Shape shape in _shapeAreas)
        {
            Console.WriteLine($"{shape.GetColor()} - {Math.Round(shape.GetArea(), 2)}");
        }
        Console.WriteLine("");

        Console.WriteLine($"The area of the {square.GetColor()} Square is: {square.GetArea()}");
        Console.WriteLine($"The area of the {rectangle.GetColor()} Rectangle is: {rectangle.GetArea()}");
        Console.WriteLine($"The area of the {circle.GetColor()} Circle is: {Math.Round(circle.GetArea(), 2)}");
    }
}