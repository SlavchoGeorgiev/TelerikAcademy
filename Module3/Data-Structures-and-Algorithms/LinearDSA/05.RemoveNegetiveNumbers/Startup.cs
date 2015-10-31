namespace _05.RemoveNegetiveNumbers
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var testList = new List<int>() { 1, 2, 3, 4, 5, -3, -1, -1, 3 - 1, 6, 0 };
            Console.WriteLine(string.Join(", ", testList));
            RemoveNegativeNumbers(testList);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(string.Join(", ", testList));
        }

        public static IList<int> RemoveNegativeNumbers(IList<int> list)
        {
            var removeStack = new Stack<int>();

            foreach (var number in list)
            {
                if (number < 0)
                {
                    removeStack.Push(number);
                }
            }

            while (removeStack.Count > 0)
            {
                list.Remove(removeStack.Pop());
            }

            return list;
        }
    }
}
