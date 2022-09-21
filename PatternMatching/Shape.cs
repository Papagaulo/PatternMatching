namespace PatternMatching;

public abstract class Shape
{
    public abstract double Area { get; }
}
public interface ISquare
{
    double Height { get; set; }
    double Width { get; set; }
}

public class Rectangle : Shape, ISquare
{
    Rectangle()
    {

    }
    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;

    }
    
    public override double Area => Height * Width;

    public double Height { get; set; }
    public double Width { get; set; }
}

public class Circle : Shape
{
    static double pi = Math.PI;
    Circle() { }
    public Circle(double diameter)
    {
        Diameter = diameter;
    }
    public double Diameter { get; set; }
    public double Radius { get => Diameter / 2; }

    public override double Area => Math.Pow(Diameter,2);
}
