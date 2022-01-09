using System;

namespace Chain_of_responsibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new FirstCheck();
            Car car1 = new CheckAssemblyCar();
            Car car2 = new ElectricCheck();
            Car car3 = new DiagnasticCheck();
            car.Next(car1);
            car1.Next(car2);
            car2.Next(car3);
            car3.Next(null);
            car.Handle();
           
        }
    }
   
    public abstract class Car
    {
        public bool Good;
        protected Car carcondition;
        
        public void Next (Car car)
        {
            this.carcondition = car;
        }

        
        public abstract void Handle();
       

    }
}
