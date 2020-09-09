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
                Console.Write("> ");
                command = ToCommand(Console.ReadLine().Trim());
                string outputString;
                switch (command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for plaaying!";
                        break;
                    case Commands.LOOK:
                        outputString = "This is an open feild west of a white house,with a boarded front door./p A rubber mat saying 'Welcome to Zork!' lies by the door.";
                        break;
                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        outputString = $"You Moved {command}";
                        break;
                    default:
                        outputString = "UnKnown command.";
                        break;
                }
                Console.WriteLine(outputString);
            }
         
        }
        private static Commands ToCommand(string commandString)
        {
           if(Enum.TryParse<Commands>(commandString, true, out Commands result))
            {
                return result;
            }
            else
            {
                return Commands.UNKNOWN;
            } 

        }

    }
}
