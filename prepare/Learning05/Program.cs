using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Red","Square", 4);
    
        //Console.WriteLine(square.GetColor() + square.GetArea());
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Green","Rectangle", 3, 2);
        //Console.WriteLine(rectangle.GetColor() + rectangle.GetArea());
        shapes.Add(rectangle);

        Circle circle = new Circle("Blue", "Circle", 4);
        //Console.WriteLine(circle.GetColor() + circle.GetArea());
        shapes.Add(circle);


    foreach (Shape areaShapes in shapes){

            string color = areaShapes.GetColor();
            string shape = areaShapes.GetNameShape();
            double area = areaShapes.GetArea();
           

            Console.WriteLine ($"Color {color} of {shape}, is: {area}.");
        }
        
    }
}