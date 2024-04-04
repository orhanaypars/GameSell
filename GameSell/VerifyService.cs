using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSell
{
    public class VerifyService : IVerifyService
    {
        public bool Verify(Customer customer)
        {
            if (customer.Id == 1 && customer.Name == "Aypars" && customer.TcNo == "25563978124" && customer.DateOfBirth == "2003")
            {
                
                Console.WriteLine("Doğrulama Başarıyla Yapılmıştır.");
                

                return true;
              
            }
            else
            {
                Console.WriteLine("Doğruma işlemi yapılmamıştır.");
                return false;
            }
        }
    }
}
