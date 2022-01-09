using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseHandler_Base_
{
    internal class Handle50 : BaseHandler
    {
        public override void HandleRequest(int amount)
        {
            if (amount >= 50)
            {
                Console.WriteLine($"Giving 50 {amount / 50}");
            }
            if (amount % 50 > 0)
            {
                if (Next != null)
                {
                    Next.HandleRequest(amount % 50);
                }
            }
        }
    }
}
