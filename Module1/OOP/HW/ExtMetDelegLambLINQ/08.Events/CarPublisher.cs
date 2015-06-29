namespace _08.Events
{
    using System;

    public class CarPublisher
    {
        public event EventHandler<MyEventArgs> RaiseMyEvent;
        public event EventHandler RaiseEvent;

        public void StartEngine()
        {
            Console.WriteLine("Engine start Brummmm :)");
            this.OnRaiseMyEvent(new MyEventArgs("Engine start."));
        }

        public void StopEngine()
        {
            Console.WriteLine("Engine stoped TrakTrak :)");
            this.OnRaiseMyEvent(new MyEventArgs("Engine Stoped.", DateTime.Now));
        }

        public void TurnLeft()
        {
            Console.WriteLine("<=");
            this.OnRaiseEvent();
        }

        public void TurnRight()
        {
            Console.WriteLine("=>");
            this.OnRaiseEvent();
        }

        protected virtual void OnRaiseMyEvent(MyEventArgs e)
        {
            EventHandler<MyEventArgs> hendeler = this.RaiseMyEvent;

            if (hendeler != null)
            {
                e.AtTime = DateTime.Now;
                hendeler(this, e);
            }
        }

        protected virtual void OnRaiseEvent()
        {
            EventHandler hendeler = this.RaiseEvent;
            hendeler(this, EventArgs.Empty);
        }
    }
}
