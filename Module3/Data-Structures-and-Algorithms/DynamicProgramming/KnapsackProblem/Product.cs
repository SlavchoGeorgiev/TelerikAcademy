namespace KnapsackProblem
{
    public class Product
    {
        public string Name { get; set; }

        public int Weight { get; set; }

        public int Cost { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
