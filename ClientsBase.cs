using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace bank_project
{
    public class ClientsBase
    {
        public int id { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? nrKonta { get; set; }
        public decimal Saldo { get; set; }
        public static List<ClientsBase> clients = new List<ClientsBase>();


        public static void ClientsBaseAdd()
        {           
            Clients.pukich(clients, out ClientsBase _, 1, "Jan", "Nowak", "001", 1457.23m);
            Clients.pukich(clients, out ClientsBase _, 2, "Agnieszka", "Kowalska", "002", 3600.18m);
            Clients.pukich(clients, out ClientsBase _, 3, "Robert", "Lewandowski", "003", 2745.03m);
            Clients.pukich(clients, out ClientsBase _, 4, "Zofia", "Plucińska", "004", 7344.00m);
            Clients.pukich(clients, out ClientsBase _, 5, "Grzegorz", "Braun", "005", 455.38m);        
        }       
    }
}

