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
        Rectangle(double height, double width)
        {
            Height = height;
            Width = width;

        }
        
        public override double Area => Height * Width;

        public double Height { get; set; }
        public double Width { get; set; }
    }
}
