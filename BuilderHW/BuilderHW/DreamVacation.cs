using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHW
{
    internal class DreamVacation : VacationBuilder
    {
        public override void GetFlight()
        {
            _Vacation.SetFlight("No Conection Flight");
        }

        public override void GetHotel()
        {
            _Vacation.SetHotel(" 5 Star Hotel");
        }

        public override void GetShuttle()
        {
            _Vacation.SetShuttle("Special Taxi ..");
        }
    }
}
