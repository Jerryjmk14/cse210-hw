using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

    
        List<Shape> shapes = new List<Shape>();

        Square myShape1 = new Square("Red", 7);
        shapes.Add(myShape1);

        Rectangle myShape2 = new Rectangle("Blue", 3, 10);
        shapes.Add(myShape2);

        Circle myShape3 = new Circle("Green", 7);
        shapes.Add(myShape3);

        foreach (Shape shape in shapes)
        {
           
            string color = shape.GetColor();

            
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}