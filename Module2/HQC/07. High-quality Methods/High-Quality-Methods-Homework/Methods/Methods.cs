namespace Methods
{
    using System;

    public class Methods
    {
        private static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("The sum of two sides of a triangle must be greater than the third");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        private static string DigitToStrting(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("Number must be integer in interval [0, 9]!");
            }
        }

        private static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("Method expect at least one number");
            }

            var maxElement = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxElement)
                {
                    maxElement = elements[i];
                }
            }

            return maxElement;
        }

        private static void PrintWithTwoDigitPrecision(object number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        private static void PrintInPersent(object number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        private static void PrintRightSideFormated(object number)
        {
            Console.WriteLine("{0,8}", number);
        }

        private static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            return distance;
        }

        private static bool IsHorizontal(double y1, double y2)
        {
            bool isHorizontal = y1 == y2;

            return isHorizontal;
        }

        private static bool IsVertical(double x1, double x2)
        {
            bool isVertical = x1 == x2;

            return isVertical;
        }

        private static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));

            Console.WriteLine(DigitToStrting(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintWithTwoDigitPrecision(1.3);
            PrintInPersent(0.75);
            PrintRightSideFormated(2.30);

            double x1 = 3;
            double y1 = -1;
            double x2 = 3;
            double y2 = 2.5;

            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));

            bool horizontal = IsHorizontal(y1, y2);
            Console.WriteLine("Horizontal? " + horizontal);

            bool vertical = IsVertical(x1, x2);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student("Peter", "Ivanov", "Sofia", DateTime.Parse("17.03.1992"));
            Student stella = new Student("Stella", "Markova", "Vidin", DateTime.Parse("03.11.1993"));

            // Student incorectStudent = new Student("", null, "Lovech", DateTime.Parse("03.11.1993"));
            Console.WriteLine("{0} is older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
