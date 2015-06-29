namespace _08.Events
{
    using System;

    class Drive
    {
        static void Main()
        {
            CarPublisher car = new CarPublisher();
            car.StartEngine();
            car.RaiseMyEvent += HandleMyEvent;
            car.RaiseEvent += HandelEvent;
            Console.WriteLine();
            car.StopEngine();
            Console.WriteLine();
            car.StartEngine();
            Console.WriteLine();
            car.TurnLeft();
            car.RaiseMyEvent += HandelEvent;
            Console.WriteLine();
            car.StopEngine();
            Console.WriteLine();
            car.RaiseEvent += (sender, e) => Console.WriteLine("Lambda");
            car.TurnRight();

            
        }

        public static void HandleMyEvent(object sender, MyEventArgs e)
        {
            Console.WriteLine("HandleMyEvent(object sender, MyEventArgs e) : ");
            Console.WriteLine(e.Message);
            Console.WriteLine(e.AtTime);
        }

        public static void HandelEvent(object sender, EventArgs e)
        {
            Console.WriteLine("HandelEvent(object sender, EventArgs e)");
        }
    }
}
