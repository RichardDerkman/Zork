using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using System.IO.Enumeration;

namespace Zork
{

   public class Program
    {
        private enum CommandLineArguments
        {
            RoomsFilename = 0
        }

        static void Main(string[] args)
        {
            const string defaultroomFilename = "Rooms.json";
            string roomFilename = (args.Length > 0 ? args[(int)CommandLineArguments.RoomsFilename] : defaultroomFilename);

            Game game = Game.Load(roomFilename);
            Console.WriteLine("Welcome to Zork!");
            game.Run();
            Console.WriteLine("Thank you for playing!");

        }

    }
}
