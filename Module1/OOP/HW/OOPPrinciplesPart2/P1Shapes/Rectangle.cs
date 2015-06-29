namespace P1Shapes
{
    public class Rectangle : Shape, IShape
    {
        public Rectangle(double widht, double height)
            : base(widht, height)
        { 
        }

        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
