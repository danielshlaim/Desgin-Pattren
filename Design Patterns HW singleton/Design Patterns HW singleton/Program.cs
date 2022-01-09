using System;
using System.Threading;

namespace Design_Patterns_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region singleton
            Console.WriteLine("Hello World!");

            Clock myclock = Clock.GetTime();
            myclock.PrintTimer();
            Thread.Sleep(1000);
            Clock myclock1 = Clock.GetTime();
            myclock1.PrintTimer();
            #endregion
        }


    }
    #region singleton
    public class Clock
    {
        private static Clock _clock;
        DateTime time = DateTime.Now;
        private static object Mylock = new object();

        private Clock()
        {

        }

        public static Clock GetTime()
        {
            if (_clock == null)
            {
                lock (Mylock)
                {
                    _clock = new Clock();

                }
            }
            return _clock;
        }

        public void PrintTimer()
        {
            Console.WriteLine(time);
        }
    }
    #endregion
}
