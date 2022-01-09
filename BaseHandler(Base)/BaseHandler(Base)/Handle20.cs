using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseHandler_Base_
{
    internal class Handle20 : BaseHandler
    {
        public override void HandleRequest(int amount)
        {
            if (amount >= 20)
            {
                Console.WriteLine($"Giving 20 {amount / 20}");
            }
            if (amount % 20 > 0)
            {
                if (Next != null)
                {
                    Next.HandleRequest(amount % 20);
                }
            }
        }
    }
}
