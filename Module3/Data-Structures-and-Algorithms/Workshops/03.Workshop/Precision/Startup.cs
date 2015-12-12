namespace Precision
{
    using System;
    public class Startup
    {
        public static void Main()
        {
            int maxDevider = int.Parse(Console.ReadLine());
            string number = "0" + Console.ReadLine().Split('.')[1];

            int bestDen = 1;
            int bestNom = 0;
            int maxPrecision = -1;

            for (int denominator = 1; denominator < maxDevider; denominator++)
            {
                int left = 0;
                int right = denominator;

                while (left < right)
                {
                    var middle = (left + right) / 2;

                    if (Compare(number, middle, denominator))
                    {
                        right = middle;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }

                var currentPrecision = GetDevidePrecision(number, left - 1, denominator);

                if (currentPrecision > maxPrecision)
                {
                    maxPrecision = currentPrecision;
                    bestNom = left - 1;
                    bestDen = denominator;
                }

                currentPrecision = GetDevidePrecision(number, left, denominator);

                if (currentPrecision > maxPrecision)
                {
                    maxPrecision = currentPrecision;
                    bestNom = left;
                    bestDen = denominator;
                }
            }

            Console.WriteLine("{0}/{1}", bestNom, bestDen);
            Console.WriteLine(maxPrecision);
        }

        private static int GetDevidePrecision(string number, int nominator, int denominator)
        {
            int i;

            for (i = 0; i < number.Length; i++)
            {
                int currentDigit = nominator / denominator;
                nominator = nominator % denominator * 10;
                if (currentDigit != number[i] - '0')
                {
                    return i;
                }
            }

            return i;
        }

        private static bool Compare(string number, int nominator, int denominator)
        {
            int i;

            for (i = 0; i < number.Length; i++)
            {
                int currentDigit = nominator / denominator;
                nominator = nominator % denominator * 10;
                if (currentDigit < number[i] - '0')
                {
                    return false;
                }
                else if (currentDigit > number[i] - '0')
                {
                    return true;
                }
            }

            return true;
        }
    }
}
