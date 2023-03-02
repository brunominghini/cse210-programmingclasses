
public class Shape{

private string _color;
private string _nameShape;

    public Shape(string color, string nameShape){
        _color = color;
        _nameShape = nameShape;
        
    }
    
    public string GetColor()
    {
        return _color;
    }

    public void setColor(string color)
    {
        _color = color;
    }

    public string GetNameShape()
    {
        return _nameShape;
    }

    public void setNameShapre(string nameShape)
    {
        _nameShape = nameShape;
    }

    public virtual double GetArea(){
        return 0;
    }
}