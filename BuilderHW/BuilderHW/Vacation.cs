using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHW
{
    internal class Vacation
    {
        private string _Flight;
        private string _Hotel;
        private string _Shuttle;

        public void SetFlight(string flight)
        {
            this._Flight = flight;
        }
        public void SetHotel(string hotel)
        {
            this._Hotel = hotel;
        }
        public void SetShuttle(string shuttle)
        {
            this._Shuttle = shuttle;
        } 

        public override string ToString()
        {
            return $"Filght : {_Flight}, Hotel : {_Hotel} , The Shuttle Is : {_Shuttle} ";
        }

       
    }
    public class VacationFluent
    {
        public bool BussnessFlight;
        public bool FancyHotel;
        public bool PrivateShuttle;

        public bool AcunommyFlight;
        public bool Hotel;
        public bool Shuttle;
    }
}
