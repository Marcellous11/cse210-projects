using System;
namespace Shapes;


class Program
{
    static void Main(string[] args)
    {
        Shapes square = new Square(4);
        Shapes rectangle = new Rectangle(4,6);
        Shapes circle = new Circle(5);

        square.Color = "Red";
        rectangle.Color = "Blue";
        circle.Color = "Yellow";

        List<Shapes> allShapes = [square, rectangle, circle];

        allShapes.ForEach(shape =>{
            Console.WriteLine($"Shape: {shape.ShapeType}, Area: {shape.GetArea()}, Color: {shape.Color}");
        });
    }
}