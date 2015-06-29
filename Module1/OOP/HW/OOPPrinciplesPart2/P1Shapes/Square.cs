namespace P1Shapes
{
    public class Square : Rectangle, IShape
    {
        public Square(double height)
            : base(height, height)
        {
        }

        public override double CalculateSurface()
        {
            return base.CalculateSurface();
        }
    }
}
