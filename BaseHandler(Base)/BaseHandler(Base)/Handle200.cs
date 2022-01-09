using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseHandler_Base_
{
    internal class Handle200 : BaseHandler
    {
        public override void HandleRequest(int amount)
        {
            if (amount >= 200)
            {
                Console.WriteLine($"Giving 200 {amount/200}");
            }
            if (amount % 200 > 0)
            {
                if (Next != null)
                {
                    Next.HandleRequest(amount % 200);
                }
            }
        }
    }
}
