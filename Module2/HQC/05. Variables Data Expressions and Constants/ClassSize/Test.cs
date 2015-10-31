namespace ClassSize
{
    using System;

    public class Test
    {
        private static void Main() 
        {
            const double fortyFiveDegreesInRadians = 0.7853981634;
            var figure = new Size(10, 10);
            Console.WriteLine("Sizes before rotation: width: {0:0.00}, height: {1:0.00}", figure.Width, figure.Height);
            var rotatedFigure = Size.GetRotatedSize(figure, fortyFiveDegreesInRadians);
            Console.WriteLine("Sizes after first rotation on 45 degrees: width: {0:0.00}, height: {1:0.00}", rotatedFigure.Width, rotatedFigure.Height);
            rotatedFigure = Size.GetRotatedSize(rotatedFigure, fortyFiveDegreesInRadians);
            Console.WriteLine("Sizes after second rotation on 45 degrees: {0:0.00}, height: {1:0.00}", rotatedFigure.Width, rotatedFigure.Height);
        }
    }
}
