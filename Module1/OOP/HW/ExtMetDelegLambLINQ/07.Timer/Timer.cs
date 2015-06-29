namespace _07.TimerExe
{
    using System;

    public class Timer
    {
        public void Execute(int second, Action method)
        {
            do
            {
                if (true)
                {
                    method();
                }
                System.Threading.Thread.Sleep(new TimeSpan(0, 0, second));
            } while (true);
        }
    }
}
