using System;
using System.Collections.Generic;
using System.Text;
using Task2.Entities;
using Task2.Services.Abstract;

namespace Task2
{
    class ProgramHelper
    {
        public readonly IGamerService _gamerService;
        public void StartApplication()
        {
            Console.WriteLine("1.Gamer Elave et");
            Console.WriteLine("2.Gamer sil");
            Console.WriteLine("3.Gamerleri gor");
            string choice = Console.ReadLine();
            Choice(choice);
        }
        public void Choice(string choice)
        {
            if (choice == "1")
            {
                Console.Write("Ad daxil edin: ");
                string name = Console.ReadLine();
                AddGamer(name);
            }
            else if (choice == "2")
            {
                Remove();
            }
            else if (choice == "3")
            {
                Details();
            }
            else
            {
                Console.WriteLine("Duzgun daxil edin!!");
                StartApplication();
            }
        }

        private void Details()
        {
            _gamerService.Details();
        }

        public void AddGamer(string name)
        {
            Gamer gamer = new Gamer()
            {
                Name = name
            };
            _gamerService.Add(gamer);
        }
        public static void Remove()
        {
            throw new NotImplementedException();
        }

    }
}
