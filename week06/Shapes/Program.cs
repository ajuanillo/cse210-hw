using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Console.WriteLine("--  SQUARE  --");
        Square square = new Square("Red", 5);

        Console.WriteLine($"Square color: {square.GetColor()}");
        Console.WriteLine($"Square area: {square.GetArea()}");

        Console.WriteLine("--  RECTANGLE  --");
        
        Rectangle rectangle = new Rectangle("Red",4, 5);
        Console.WriteLine($"Rectangle color: {rectangle.GetColor()}");
        Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");
        
        Console.WriteLine("--  CIRCLE  --");
        Circle circle = new Circle("Red",4);
        Console.WriteLine($"Circle color: {circle.GetColor()}");
        Console.WriteLine($"Circle area: {circle.GetArea()}");

        List<Shape> shapes = new List<Shape>(){square,rectangle,circle};

        Console.WriteLine("--  Looping Shape List  --");

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape color: {shape.GetColor()}");
            Console.WriteLine($"Shape area: {shape.GetArea()}");
        }


    }
}