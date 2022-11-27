using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_project
{
    public class Clients : ClientsBase
    {     
        public static void pukich(List<ClientsBase> clients, out ClientsBase client, int id_, string firstName_, string lastName_, string nrKonta_, decimal Saldo_)
        {
            client = new ClientsBase()
            {
                id = id_,
                firstName = firstName_,
                lastName = lastName_,
                nrKonta = nrKonta_,
                Saldo = Saldo_
            };

            clients.Add(client);
        }


        public static void ShowClient(List<ClientsBase> clients)
        {
            foreach (var client in clients)
            {
                Console.WriteLine($" {client.id} | {client.firstName} | {client.lastName} | {client.nrKonta} | {client.Saldo}");
            }          
        }
    }
}
