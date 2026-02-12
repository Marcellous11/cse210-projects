namespace Shapes;

public abstract class Shapes{
    public string Color {get;set;}
    public abstract string ShapeType {get;}

    public abstract double GetArea();
}