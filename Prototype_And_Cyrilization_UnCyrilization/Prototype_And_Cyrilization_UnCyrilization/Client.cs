using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_And_Cyrilization_UnCyrilization
{
    internal class Client
    {
        public Client(string firstName, string lastName, int iD, int phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = iD;
            PhoneNumber = phoneNumber;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public int PhoneNumber { get; set; }
     


        public Client Clone()
        {
            Client clone = new Client(this.FirstName, this.LastName , this.ID , this.PhoneNumber);
            return clone;
        }
    }
}
