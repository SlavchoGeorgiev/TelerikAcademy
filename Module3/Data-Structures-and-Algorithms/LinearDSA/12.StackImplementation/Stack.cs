namespace _12.StackImplementation
{
    using System;

    public class Stack<T>
    {
        private T[] stack;

        public Stack(int capacity = 4)
        {
            this.Capacity = capacity;
            this.stack = new T[this.Capacity];
            this.CurrentIndex = -1;
            this.Count = 0;
        }

        public int Capacity { get; private set; }

        public int Count { get; private set; }

        private int CurrentIndex { get; set; }

        public Stack<T> Push(T item)
        {
            if (this.Capacity <= this.Count)
            {
                this.Resize();
            }

            this.CurrentIndex++;
            this.Count++;
            this.stack[this.CurrentIndex] = item;

            return this;
        }

        public T Pop()
        {
            if (this.Count > 0)
            {
                T popItem = this.stack[this.CurrentIndex];
                this.CurrentIndex--;
                this.Count--;

                return popItem;
            }
            else
            {
                throw new InvalidOperationException("Stack is empty, operation Pop is not valid.");
            }
        }

        public T Peek()
        {
            if (this.Count > 0)
            {
                return this.stack[this.CurrentIndex];
            }
            else
            {
                throw new InvalidOperationException("Stack is empty, operation Peek is not valid.");
            }
        }

        private void Resize()
        {
            var oldStack = this.stack;
            this.Capacity = this.Capacity * 2;
            this.stack = new T[this.Capacity];

            for (int index = 0; index < oldStack.Length; index++)
            {
                this.stack[index] = oldStack[index];
            }
        }
    }
}
