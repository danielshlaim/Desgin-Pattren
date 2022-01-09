using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_HW
{
    internal class Adapter :PayWithEuro
    {
        private PayWithDollar AdapterExchange = new PayWithDollar();
        public double ConvertToEuro(double a)
        {
            return AdapterExchange.DollarPayment((int)a);
        }
        
    }
}