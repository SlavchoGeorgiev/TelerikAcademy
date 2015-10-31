namespace IfStatements
{
    public class RefactorIfs
    {
        static void Main()
        {
            Potato potato;

            // ... 

            if (potato != null && potato.isPeeled && !potato.IsRotten)
            {
                Cook(potato);
            }

            bool isXInRange = IsInClosedRange(MinX, MaxX, x);
            bool isYInRange = IsInClosedRange(MinY, MaxY, y);

            if (shouldVisitCell && isXInRange && isYInRange)
            {
               VisitCell();
            }
        }

        private static bool IsInClosedRange(double min, double max, double number)
        {
            if (min <= number && number <= max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
