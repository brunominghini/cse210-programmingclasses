public class Circle: Shape
{
    private double _radius;


    public Circle (string color, string nameShape, double radius): base (color, nameShape){
        _radius = radius;
    }

    public override double GetArea()
    {
        return 3.14*(_radius*_radius);
    }
}
