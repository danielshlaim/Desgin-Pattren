using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_HW
{
    internal class PayWithEuro
    {
      
        public double EuroPayment(double euro)
        {
            return euro *3.5;
        }
    }
}
