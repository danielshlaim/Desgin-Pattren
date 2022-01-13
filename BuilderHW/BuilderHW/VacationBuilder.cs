using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHW
{
    internal abstract class  VacationBuilder
    {
        protected Vacation _Vacation;
        public VacationBuilder()
        {
            _Vacation = new Vacation();

        }
        public abstract void GetFlight();
        public abstract void GetHotel();
        public abstract void GetShuttle();

        public void CreateVacation()
        {
            GetFlight();
            GetHotel();
            GetShuttle();
        }
        public Vacation GetVacation()
        {
            return _Vacation;
        }

      

    }
    public class VacationFluentBuilder
    {
        public VacationFluent vacationfluent = new VacationFluent();
       public  VacationFluent build() => vacationfluent;

        public VacationFluentBuilder GetBussnessFlight()
        {
            if (vacationfluent.AcunommyFlight == true)
            {
                vacationfluent.AcunommyFlight = false;
            }
            vacationfluent.BussnessFlight = true;
            return this;
        }
        public VacationFluentBuilder GetFancyHotel()
        {
            if (vacationfluent.Hotel == true)
            {
                vacationfluent.AcunommyFlight = false;
            }
            vacationfluent.FancyHotel = true;
            return this;
        }
        public VacationFluentBuilder GetPrivatShuttle()
        {
            if (vacationfluent.Shuttle == true)
            {
                vacationfluent.Shuttle = false;
            }
            vacationfluent.PrivateShuttle = true;
            return this;
        }

        public VacationFluentBuilder GetFlight()
        {
            if (vacationfluent.BussnessFlight == true)
            {
                vacationfluent.BussnessFlight = false;
            }
            vacationfluent.AcunommyFlight = true;
            return this;
        }
        public VacationFluentBuilder GetHotel()
        {
            if (vacationfluent.FancyHotel == true)
            {
                vacationfluent.FancyHotel = false;
            }
            vacationfluent.Hotel = true;
            return this;
        }
        public VacationFluentBuilder GetShullte()
        {
            if (vacationfluent.PrivateShuttle == true)
            {
                vacationfluent.PrivateShuttle = false;
            }
            vacationfluent.Shuttle = true;
            return this;
        }
    }
}
