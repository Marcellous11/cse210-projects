namespace Shapes;

class Rectangle:Shapes{

    private double _length;
    private double _width;

    public override string ShapeType => "Rectangle";

    public Rectangle(double length,double width){
        _length = length;
        _width = width;
    }

    public override double GetArea(){
        return _length * _width;
    }
}