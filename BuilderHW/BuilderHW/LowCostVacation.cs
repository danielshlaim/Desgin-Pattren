using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHW
{
    internal class LowCostVacation : VacationBuilder
    {
        public override void GetFlight()
        {
            _Vacation.SetFlight("Conection Flight");
        }

        public override void GetHotel()
        {
            _Vacation.SetHotel("3 Star Hotel");
        }

        public override void GetShuttle()
        {
            _Vacation.SetShuttle("Bus To The Air Port");
        }
    }
}
