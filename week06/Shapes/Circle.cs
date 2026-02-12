namespace Shapes;

class Circle:Shapes{
    private double _radius;

    public override string ShapeType => "Circle";

    public Circle(double radius){
        _radius = radius;
    }

    public override double GetArea(){
        return Math.PI * (_radius * _radius) ;
    }
}