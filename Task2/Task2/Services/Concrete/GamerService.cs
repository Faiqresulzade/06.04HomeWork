using System;
using System.Collections.Generic;
using System.Text;
using Task2.Entities;
using Task2.Services.Abstract;

namespace Task2.Services.Concrete
{
    class GamerService : IGamerService
    {
        List<Gamer> gamers;
        public void Add(Gamer gamer)
        {
            gamers.Add(gamer);
        }

        public void Details(Gamer gamer)
        {
            Console.WriteLine(gamers);
        }

        public void Remove(Gamer gamer)
        {
            gamers.Remove(gamer);
        }
    }
}
