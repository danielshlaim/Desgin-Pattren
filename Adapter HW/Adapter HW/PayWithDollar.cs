using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_HW
{
    internal class PayWithDollar
    {
        
        public int DollarPayment( int dollar)
        {
            return dollar * 3;
        }
    }
}
