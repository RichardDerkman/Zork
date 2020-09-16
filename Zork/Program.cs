using System;

namespace Zork
{
    enum Commands
    {
        QUIT,
        LOOK,
        NORTH,
        SOUTH,
        EAST,
        WEST,
        UNKNOWN
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");
            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.WriteLine(Rooms[CurrentRoomIndex]);
                Console.Write("> ");
                command = ToCommand(Console.ReadLine().Trim());
                string outputString;
                switch (command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for plaaying!";
                        break;
                    case Commands.LOOK:
                        outputString = "This is an open feild west of a white house,with a boarded front door./n A rubber mat saying 'Welcome to Zork!' lies by the door.";
                        break;
                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        outputString = Move(command) ? $"You Moved {command}": $"The way is shut";
                        break;
                    default:
                        outputString = "UnKnown command.";
                        break;
                }
                Console.WriteLine(outputString);
            }

        }
        private static Commands ToCommand(string commandString) => Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN;

       private static string[] Rooms =
      {
        "Forest",
        "West of House",
        "Behind House",
        "Clearing",
        "Canton View" 

    };
        private static bool Move(Commands command)
        {
            bool didmove = false;
            switch (command)
            {

                case Commands.EAST when CurrentRoomIndex < Rooms.Length - 1:
                        CurrentRoomIndex++;
                        didmove = true;
                         break;
                case Commands.WEST when CurrentRoomIndex > 0:
                    
                        CurrentRoomIndex--;
                    didmove = true;
                    break;

            }
            return didmove;
        }
        private static int CurrentRoomIndex = 1;
    }
}
