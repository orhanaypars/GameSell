using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSell
{
    public interface IGamerService
    {
        void Add(Customer customer);
        void Sell(Customer customer);
        void Offer(Customer customer,Game game);
    }
}
