namespace Deviders
{
    using System;

    public class Startup
    {
        public static int result;
        public static int numberOfDeviders;

        public static int[] numbers;
        public static bool[] used;

        public static int[] currentNumber;

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            numbers = new int[n];
            currentNumber = new int[n];
            used = new bool[n];
            numberOfDeviders = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Solve(numbers, 0);
            Console.WriteLine(result);
        }

        private static void Solve(int[] arr, int index)
        {
            if (index == numbers.Length)
            {
                int number = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    number = number * 10 + currentNumber[i];
                }

                var currentDividers = 2;

                for (int i = 2; i <= number / 2 + 1; i++)
                {
                    if (number % i == 0)
                    {
                        currentDividers++;
                    }
                }

                if (currentDividers.CompareTo(numberOfDeviders) == 0 && result.CompareTo(number) > 0)
                {
                    result = number;
                    numberOfDeviders = currentDividers;
                }
                else if (currentDividers.CompareTo(numberOfDeviders) < 0)
                {
                    result = number;
                    numberOfDeviders = currentDividers;
                }

                //Console.WriteLine($"{number} => {currentDividers}");
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    currentNumber[index] = arr[i];
                    Solve(arr, index + 1);
                    used[i] = false;
                }
            }
        }
    }
}
