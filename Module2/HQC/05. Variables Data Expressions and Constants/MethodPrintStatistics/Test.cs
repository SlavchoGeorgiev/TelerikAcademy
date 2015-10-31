namespace MethodPrintStatistics
{
    using System;

    private class Test
    {
        private static void Main()
        {
            double[] testArray = { 1, 2, 23, -1, 16.5, 3.14 };
            Print.PrintStatistics(testArray, testArray.Length);
            Print.PrintValue(13, "Fatal");
        }
    }
}
