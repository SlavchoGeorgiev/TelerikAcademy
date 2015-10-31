namespace _12.StackImplementation
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var myStack = new Stack<int>();

            myStack
                .Push(3)
                .Push(2)
                .Push(-1)
                .Push(6)
                .Push(7)
                .Push(-1)
                .Push(3)
                .Push(2)
                .Push(-1)
                .Push(6)
                .Push(7)
                .Push(21);

            Console.WriteLine("Peek: {0}", myStack.Peek());

            while (myStack.Count > 0)
            {
                Console.Write(myStack.Pop() + " ");
            }
        }
    }
}
