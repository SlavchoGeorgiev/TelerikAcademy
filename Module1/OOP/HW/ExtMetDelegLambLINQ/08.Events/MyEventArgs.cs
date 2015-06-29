namespace _08.Events
{
    using System;

    public class MyEventArgs : EventArgs
    {
        public MyEventArgs(string message) : this(message, default(DateTime))
        {
        }

        public MyEventArgs(string message, DateTime time)
        {
            this.Message = message;
            this.AtTime = time;
        }

        public string Message { get; set; }
        private DateTime atTime;

        public DateTime AtTime
        {
            get { return this.atTime; }
            set { this.atTime = value; }
        }
    }
}
