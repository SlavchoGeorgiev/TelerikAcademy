namespace P1Shapes
{
    public interface IShape
    {
        double Width { get; set; }

        double Height { get; set; }

        double CalculateSurface();
    }
}
