using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSell
{
    public class CustomerManager : IGamerService
    {
        IVerifyService _verifyService;

        public CustomerManager(IVerifyService verifyService)
        {
            _verifyService = verifyService;
        }

        public void Add(Customer customer)
        {
            if (_verifyService.Verify(customer)==true)
            {
                Console.WriteLine("Kayıt Başarıyla eklenmiştir.");
            }
            else
            {
                Console.WriteLine("Kayıt Başarısız doğrulama işlemi yapılamamıştır.");
            }
        }

        public void Sell(Customer customer)
        {
            Console.WriteLine("Silme işlemi başarıyla gerçekleşmiştir.");
        }

        public void Offer(Customer customer,Game game)
        {
            Console.WriteLine("İsmi : "+game.GameName+"oyunda %50 kampanya uygulanmıştır."+(game.GamePrice/100)*50);
        }
    }
}
