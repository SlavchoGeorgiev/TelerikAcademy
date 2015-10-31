namespace _02.CompareSimpleMaths
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    public static class MathTester
    {
        private const string resultFormat = "Test for {0} of {1}. Average time: {2} milliseconds";

        public static string TestIntAdding(int testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    int operationResult = testValue + testValue;
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "adding", "int", testResults.Average());
        }

        public static string TestLongAdding(long testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    long operationResult = testValue + testValue;
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "adding", "long", testResults.Average());
        }

        public static string TestFloatAdding(float testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    float operationResult = testValue + testValue;
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "adding", "float", testResults.Average());
        }

        public static string TestDoubleAdding(double testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    double operationResult = testValue + testValue;
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "adding", "double", testResults.Average());
        }

        public static string TestDecimalAdding(decimal testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    decimal operationResult = testValue + testValue;
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "adding", "decimal", testResults.Average());
        }

        public static string TestIntSubtract(int testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    int operationResult = testValue - testValue;
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "subtract", "int", testResults.Average());
        }

        public static string TestLongSubtract(long testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    long operationResult = testValue - testValue;
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "subtract", "long", testResults.Average());
        }

        public static string TestFloatSubtract(float testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    float operationResult = testValue - testValue;
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "subtract", "float", testResults.Average());
        }

        public static string TestDoubleSubtract(double testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    double operationResult = testValue - testValue;
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "subtract", "double", testResults.Average());
        }

        public static string TestDecimalSubtract(decimal testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    decimal operationResult = testValue - testValue;
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "subtract", "decimal", testResults.Average());
        }

        public static string TestIntIncrement(int testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    int operationResult = ++testValue;
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "increment", "int", testResults.Average());
        }

        public static string TestLongIncrement(long testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    long operationResult = ++testValue;
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "increment", "long", testResults.Average());
        }

        public static string TestFloatIncrement(float testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    float operationResult = ++testValue;
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "increment", "float", testResults.Average());
        }

        public static string TestDoubleIncrement(double testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    double operationResult = ++testValue;
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "increment", "double", testResults.Average());
        }

        public static string TestDecimalIncrement(decimal testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    decimal operationResult = ++testValue;
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "increment", "decimal", testResults.Average());
        }

        public static string TestIntMultiply(int testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    int operationResult = testValue * testValue;
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "Multiply", "int", testResults.Average());
        }

        public static string TestLongMultiply(long testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    long operationResult = testValue * testValue;
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "Multiply", "long", testResults.Average());
        }

        public static string TestFloatMultiply(float testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    float operationResult = testValue * testValue;
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "Multiply", "float", testResults.Average());
        }

        public static string TestDoubleMultiply(double testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    double operationResult = testValue * testValue;
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "Multiply", "double", testResults.Average());
        }

        public static string TestDecimalMultiply(decimal testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    decimal operationResult = testValue * testValue;
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "Multiply", "decimal", testResults.Average());
        }

        public static string TestIntDivide(int testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    int operationResult = testValue / testValue;
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "Divide", "int", testResults.Average());
        }

        public static string TestLongDivide(long testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    long operationResult = testValue / testValue;
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "Divide", "long", testResults.Average());
        }

        public static string TestFloatDivide(float testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    float operationResult = testValue / testValue;
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "Divide", "float", testResults.Average());
        }

        public static string TestDoubleDivide(double testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    double operationResult = testValue / testValue;
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "Divide", "double", testResults.Average());
        }

        public static string TestDecimalDivide(decimal testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    decimal operationResult = testValue / testValue;
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "Divide", "decimal", testResults.Average());
        }

        public static string TestFloatSqrt(float testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    double operationResult = Math.Sqrt(testValue);
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "Sqrt", "float", testResults.Average());
        }

        public static string TestDoubleSqrt(double testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    double operationResult = Math.Sqrt(testValue);
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "Sqrt", "double", testResults.Average());
        }

        public static string TestDecimalSqrt(decimal testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    double operationResult = Math.Sqrt((double)testValue);
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "Sqrt", "decimal", testResults.Average());
        }

        public static string TestFloatLog(float testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    double operationResult = Math.Log(testValue);
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "natural logarithm", "float", testResults.Average());
        }

        public static string TestDoubleLog(double testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    double operationResult = Math.Log(testValue);
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "natural logarithm", "double", testResults.Average());
        }

        public static string TestDecimalLog(decimal testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    double operationResult = Math.Log((double)testValue);
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "natural logarithm", "decimal", testResults.Average());
        }

        public static string TestFloatSin(float testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    double operationResult = Math.Sin(testValue);
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "sinus", "float", testResults.Average());
        }

        public static string TestDoubleSin(double testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    double operationResult = Math.Sin(testValue);
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "sinus", "double", testResults.Average());
        }

        public static string TestDecimalSin(decimal testValue, int testCount, int iterationsCountPerTest)
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    double operationResult = Math.Sin((double)testValue);
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "sinus", "decimal", testResults.Average());
        }
    }
}

