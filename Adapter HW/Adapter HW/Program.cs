using System;

namespace Adapter_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PayWithEuro ExchagingEuro = new Adapter();
            int num = new Random().Next(10);
            PayMehtod(ExchagingEuro, num);
        }
        public static  void PayMehtod(PayWithEuro paywitheuro ,double number )
        {
            Console.WriteLine(paywitheuro.EuroPayment(number));
        }
    }
}
