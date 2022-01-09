using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseHandler_Base_
{
    internal class handle100 : BaseHandler
    {
        public override void HandleRequest(int amount)
        {
            if (amount >= 100)
            {
                Console.WriteLine($"Giving 100 {amount / 100}");
            }
            if (amount % 100 > 0)
            {
                if (Next != null)
                {
                    Next.HandleRequest(amount % 100);
                }
            }
        }
    }
}
