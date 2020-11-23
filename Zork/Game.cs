using System;
using System.IO;
using Newtonsoft.Json;

namespace Zork
{
    public class Game
    {

        public World World { get; private set; }

    

        [JsonIgnore]
        public Player Player { get; private set; }

        [JsonIgnore]
        private bool IsRunning { get; set; }

        public Game(World world , Player player)
        {
            World = world;
            Player = player;
        }

        internal static Game Load(object defaultFileSystemName)
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            IsRunning = true;
            Room previousRoom = null;

            while (IsRunning)
            {
                Console.WriteLine(Player.Location);
                if (previousRoom != Player.Location)
                {
                    Console.WriteLine(Player.Location.Description);
                    previousRoom = Player.Location;
                }
                Console.Write("\n> ");
                Commands command = ToCommand(Console.ReadLine().Trim());
                switch (command)
                {
                    case Commands.QUIT:
                        Console.WriteLine("Thank you for playing!");
                        break;
                    case Commands.LOOK:
                        Console.WriteLine(Player.Location.Description);
                        break;
                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        Directions directions = Enum.Parse<Directions>(command.ToString(), true);
                        if (Player.Move(directions) == false)
                        {
                            Console.WriteLine("The way is shut!");
                        }
                        break;
                    default:
                        Console.WriteLine("UnKnown command.");
                        break;
                }
            }
        }
        public static Game Load(string FileSystemName)
        {
            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(FileSystemName));
            game.Player = game.World.spawnPlayer();
            return game;
        }
        private static Commands ToCommand(string commandString) => Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN;
        }
    }

