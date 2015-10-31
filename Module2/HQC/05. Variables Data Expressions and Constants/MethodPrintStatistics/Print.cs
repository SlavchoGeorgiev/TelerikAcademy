namespace MethodPrintStatistics
{
    using System;

    public static class Print
    {
        public static void PrintValue(double input, string name)
        {
            Console.WriteLine("{0} value is: {1}", name, input);
        }

        public static void PrintStatistics(double[] numbersColection, int count)
        {
            double max = FindMaxValue(numbersColection, count);
            PrintValue(max, "Maximal");
            double min = FindMinValue(numbersColection, count);
            PrintValue(min, "Minimal");
            double average = FindAverageValue(numbersColection, count);
            PrintValue(average, "Average");
        }

        private static double FindAverageValue(double[] numbersColection, int count)
        {
            double sum = 0;

            for (int i = 0; i < count; i++)
            {
                sum += numbersColection[i];
            }

            var average = sum / count;

            return average;
        }

        private static double FindMinValue(double[] numbersColection, int count)
        {
            double min = double.MaxValue;

            for (int i = 0; i < count; i++)
            {
                if (numbersColection[i] < min)
                {
                    min = numbersColection[i];
                }
            }

            return min;
        }

        private static double FindMaxValue(double[] numbersColection, int count)
        {
            double max = double.MinValue;

            for (int i = 0; i < count; i++)
            {
                if (numbersColection[i] > max)
                {
                    max = numbersColection[i];
                }
            }

            return max;
        }
    }
}
