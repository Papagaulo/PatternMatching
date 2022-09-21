namespace PatternMatching
{
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

    internal class Circle : Shape
    {
        static double pi = Math.PI;
        Circle(double diameter)
        {
            Diameter = diameter;
        }
        public double Diameter { get; set; }

        public override double Area => throw new NotImplementedException();
    }
}
