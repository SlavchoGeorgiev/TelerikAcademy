namespace P1Shapes
{
    public class Triangle : Shape, IShape
    {
        public Triangle(double widht, double height)
            : base(widht, height)
        { 
        }

        public override double CalculateSurface()
        {
            return this.Height * this.Width / 2;
        }
    }
}
