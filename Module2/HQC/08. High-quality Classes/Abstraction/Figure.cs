namespace Abstraction
{
    public abstract class Figure
    {
        public abstract double Width { get; set; }

        public abstract double Height { get; set; }

        public abstract double Perimeter { get; }

        public abstract double Surface { get; }
    }
}
