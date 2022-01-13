using System;
using System.Text.Json;

namespace Prototype_And_Cyrilization_UnCyrilization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Gil","Hagever",123000,00005);
            InVoice inVoice = new InVoice(client,500,new DateTime(2000,01,15));

            //InVoice inVoice1 =inVoice.Clone();
            InVoice inVoice2 = DeepCopy<InVoice>(inVoice);
            client.FirstName = "Or";
            Console.WriteLine(inVoice);
            Console.WriteLine(inVoice2);
        }

        public static T DeepCopy<T>(T info)
        {
            var jason  = JsonSerializer.Serialize(info);
            T obj = JsonSerializer.Deserialize<T>(jason);
            return obj;

        }
    }
}
