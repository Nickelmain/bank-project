using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_project
{
    public class DisplayStartScreen
    {
        public static void ShowStartScreen()
        {
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("WYBIERZ OPCJĘ: ");
                Console.WriteLine("");
                Console.WriteLine("1 => LISTA WSZYSTKICH KLIENTÓW BANKU ");
                Console.WriteLine("");
                Console.WriteLine("2 => LOGOWANIE ");
                Console.WriteLine("");
                Console.WriteLine("3 => ZAKOŃCZ PROGRAM ");

                string? choice = Console.ReadLine();
                bool ifTrue = int.TryParse(choice, out int result);

                if (ifTrue)
                {
                    switch (result)
                    {
                        case 1:
                            Console.Clear();
                            Clients.ShowClient(Clients.clients);
                            flag = true;
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("LOGOWANIE");
                            flag = false;
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("RETURN");
                            flag = false;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("TRY AGAIN");
                            flag = true;
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("TRY AGAIN");
                    flag = true;
                }
            }
        }       
    }
}
