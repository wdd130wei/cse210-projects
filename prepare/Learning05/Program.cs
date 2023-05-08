using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Blue", 5));
        shapes.Add(new Circle("Red", 5));
        shapes.Add(new Rectangle("Yellow", 5, 7));

        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();
            Console.WriteLine ($"{area} {color}");
        }
    }
}