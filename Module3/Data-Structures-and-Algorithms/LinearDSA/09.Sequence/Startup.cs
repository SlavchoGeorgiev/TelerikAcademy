namespace _09.Sequence
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var currentSequence = FindSequence(2, 50);

            Console.WriteLine(string.Join(", ", currentSequence));
        }

        public static Queue<int> FindSequence(int n, int membersNumber)
        {
            var sequence = new Queue<int>();
            var sequenceForCalculating = new Queue<int>();
            var s = n;
            sequence.Enqueue(s);
            sequenceForCalculating.Enqueue(s);

            for (int i = 0; i < membersNumber / 3; i++)
            {
                s = sequenceForCalculating.Dequeue();
                sequence.Enqueue(s + 1);
                sequenceForCalculating.Enqueue(s + 1);

                sequence.Enqueue((2 * s) + 1);
                sequenceForCalculating.Enqueue((2 * s) + 1);

                sequence.Enqueue(s + 2);
                sequenceForCalculating.Enqueue(s + 2);
            }

            return sequence;
        }
    }
}
