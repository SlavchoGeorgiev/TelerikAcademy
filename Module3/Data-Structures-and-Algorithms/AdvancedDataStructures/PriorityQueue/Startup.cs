namespace PriorityQueue
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var pq = new PriorityQueue<string>();
            pq.Enqueue(1, "Last")
                .Enqueue(99, "First")
                .Enqueue(1, "Last")
                .Enqueue(16, "Middle")
                .Enqueue(0, "After last");

            while (pq.Count > 0)
            {
                Console.WriteLine(pq.Dequeue());
            }
        }
    }
}
