using System;
using System.Collections.Generic;
using System.Text;
using Task2.Entities;

namespace Task2.Services.Abstract
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void Remove(Gamer gamer);
        void Details(Gamer gamer);
    }
}
