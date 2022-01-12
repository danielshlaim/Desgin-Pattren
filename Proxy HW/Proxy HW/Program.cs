using System;

namespace Proxy_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.ChangePassportPhoto(client);
            client.ChangeAddress(client,"new york");
            client.UpdatePassPort(client);

            Management management = new Management();
            management.ADDClient(client);
            management.REMOVEClient(client);
        }
    }

    public interface IInteriorOffice
    {


        void ADDClient(Client client);
        void REMOVEClient(Client client);
        



    }
    public interface IServiceMachine
    {
        void UpdatePassPort(Client client);
        void ChangeAddress(Client client, string addressInput);
        void ChangePassportPhoto(Client client);

    }
    public class Client : IServiceMachine
    {
        public string Address { get; set; }
        public string Passport { get; set; }
        public DateTime PassportEndDate { get; set; }

        public void ChangeAddress(Client client,string addressInput)
        {
            this.Address = addressInput;
            Console.WriteLine($"Address Has Been changed To: {Address}");
        }

        

        public void ChangePassportPhoto(Client client)
        {
            Console.WriteLine("the Photo has been Change Successfully");
        }

        public void UpdatePassPort(Client client)
        {
            PassportEndDate.AddYears(5).ToString();
            Console.WriteLine("the passport has been updated");
        }
      
    }

   
}
