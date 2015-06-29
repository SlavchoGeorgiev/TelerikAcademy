namespace P3RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
        where T : IComparable
    {
        public InvalidRangeException(string message)
            : this(message, default(T), default(T))
        { 
        }

        public InvalidRangeException(string message, T start, T end)
            : base(message)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start { get; set; }

        public T End { get; set; }
    }
}
