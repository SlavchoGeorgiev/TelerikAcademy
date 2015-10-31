namespace RefactorLoop
{
    using System;

    class TheLoop
    {
        static void Main()
        {
            bool isFound = false;

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(array[i]);

                if (array[i] == expectedValue && i % 10 == 0)
                {
                    isFound = true;
                    break;
                }
            }

            // More code here

            if (isFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
