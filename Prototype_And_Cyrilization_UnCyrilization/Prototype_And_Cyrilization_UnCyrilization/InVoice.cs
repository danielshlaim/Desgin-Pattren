using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_And_Cyrilization_UnCyrilization
{
    internal class InVoice 
    {
        public Client _client { get; set; }
        public int PricePayed { get; set; }
        public int Vat { get; set; } = 17;
        public DateTime DealTime { get; set; }



        public InVoice()
        {

        }

        public InVoice(Client client, int Bill, DateTime dealTime)
        {
            _client = client;
            PricePayed = Bill + (Bill* (Vat /100));
            DealTime = dealTime;
        }

        public InVoice Clone()
        {
            InVoice inVoiceClone = new InVoice(_client/*.Clone()*/,this.PricePayed,this.DealTime);
            return inVoiceClone;
        }
        public override string ToString()
        {
            return $"client : {_client.FirstName} PricePayed : {PricePayed}" ;
        }
    }
}
