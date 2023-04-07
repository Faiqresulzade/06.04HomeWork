using System;
using Task2.Entities;
using Task2.Services.Abstract;

namespace Task2
{
    class Program
    {
        private readonly IGamerService _gamerService;

        public Program(IGamerService gamerService)
        {
            _gamerService = gamerService;
        }
        static void Main(string[] args)
        {
            ProgramHelper programHelper = new ProgramHelper();
            programHelper.StartApplication();
        }
      
    }
}
