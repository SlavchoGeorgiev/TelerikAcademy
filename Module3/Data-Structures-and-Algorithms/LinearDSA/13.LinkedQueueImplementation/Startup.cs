namespace _13.LinkedQueueImplementation
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var myLinkedQueue = new LinkedQueue<int>()
                .Enqueue(2)
                .Enqueue(4)
                .Enqueue(6)
                .Enqueue(8)
                .Enqueue(10)
                .Enqueue(11)
                .Enqueue(15)
                .Enqueue(18)
                .Enqueue(0);

            Console.WriteLine("Peek: {0}", myLinkedQueue.Peek());

            while (myLinkedQueue.Count > 0)
            {
                Console.Write(myLinkedQueue.Dequeue() + " ");
            }
        }
    }
}
