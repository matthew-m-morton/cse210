public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width)
    {
        this._color = color;
        _length = length;
        _width = width; 
    }

    public override double GetArea()
    {
        double area = _length*_width;
        return area;
    }
}