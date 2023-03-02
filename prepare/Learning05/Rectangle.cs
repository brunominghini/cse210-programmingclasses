public class Rectangle: Shape
{
    private double _length;
    private double _width;


    public Rectangle (string color,string nameShape, double length, double width): base (color, nameShape){
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length*_width;
    }
}
