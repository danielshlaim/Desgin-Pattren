using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_HW
{
    public class Management : IInteriorOffice , IServiceMachine
    {
        public void ADDClient(Client client)
        {
            Console.WriteLine("the Client Added successfully");
        }

        public void ChangeAddress(Client client, string addressInput)
        {
            var address = addressInput;
            Console.WriteLine($"the Address Has Been Change {address}");
        }

        public void ChangePassportPhoto(Client client)
        {
            Console.WriteLine("the Photo Has Been Chage Successfully");
        }

        public void REMOVEClient(Client client)
        {
            Console.WriteLine("the Client Removed!");
        }

        public void UpdatePassPort(Client client)
        {
            Console.WriteLine("the Passport Has Been Updated! :)");
        }
    }
}
