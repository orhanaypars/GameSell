using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new VerifyService());
            Customer customer = new Customer { Id = 1, Name = "Aypard", TcNo = "25563978124", DateOfBirth = "2003" };
            

            Game game = new Game {GameId=1,GameName="GTA VI",GamePrice=2750 };
            customerManager.Add(customer);
            
            Console.ReadKey();
                
        }
    }
}
