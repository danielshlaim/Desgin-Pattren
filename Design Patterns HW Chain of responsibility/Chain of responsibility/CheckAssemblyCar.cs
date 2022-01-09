using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility
{
    public class CheckAssemblyCar : Car
    {
        public override void Handle()
        {

            int Grade = new Random().Next(1, 11);
            if (Grade >= 6)
            {
                Good = true;
                Console.WriteLine($"The Car Condition Is OK");
            }
            else
            {
                if (carcondition != null)
                {
                    Console.WriteLine("the Check Is Fail");
                    carcondition.Handle();
                }

            }
        }
    }
}
