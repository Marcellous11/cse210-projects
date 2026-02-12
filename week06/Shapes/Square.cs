namespace Shapes;
class Square:Shapes{

    private double _side;
    public override string ShapeType => "Shape";

    public Square(double side){
        _side = side;
    }
    public override double GetArea(){
        return _side * _side;
    }
}