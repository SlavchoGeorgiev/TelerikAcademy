namespace _07.TimerExe
{
    using System;

    class TimerTest
    {
        static int counter = 1;
        static void Main()
        {
            Timer testTimer = new Timer();
            testTimer.Execute(2, MyMethod);
        }
        private static void MyMethod()
        {
            Console.WriteLine("Executed {0} times!", counter++);
        }
    }
}
