using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppjeMaandag.Commands
{
    class MoveCommand
    {

        public static void Move(string subCommand)
        {

            string ignoredCase = subCommand.ToLower();

            switch (ignoredCase)
            {
                case "north":
                    if ( Game.currentRoom.NorthConnection != null)
                    {
                        Game.currentRoom = Game.currentRoom.NorthConnection;
                        Console.WriteLine("Je bent nu in de {0}", Game.currentRoom.RoomName);
                    } else
                    {
                        Console.WriteLine("Geen geldige richting.");
                    }
                    break;
                case "east":
                    if (Game.currentRoom.EastConnection != null)
                    {
                        Game.currentRoom = Game.currentRoom.EastConnection;
                        Console.WriteLine("Je bent nu in de {0}", Game.currentRoom.RoomName);
                    }
                    else
                    {
                        Console.WriteLine("Geen geldige richting.");
                    }
                    break;
                case "south":
                    if (Game.currentRoom.SouthConnection != null)
                    {
                        Game.currentRoom = Game.currentRoom.SouthConnection;
                        Console.WriteLine("Je bent nu in de {0}", Game.currentRoom.RoomName);
                    }
                    else
                    {
                        Console.WriteLine("Geen geldige richting.");
                    }
                    break;
                case "west":
                    if (Game.currentRoom.WestConnection != null)
                    {
                        Game.currentRoom = Game.currentRoom.WestConnection;
                        Console.WriteLine("Je bent nu in de {0}", Game.currentRoom.RoomName);
                    }
                    else
                    {
                        Console.WriteLine("Geen geldige richting.");
                    }
                    break;
                default:
                    Console.WriteLine("Geen geldig commando, voer \"help\" in voor een lijst met geldige commando's");
                    break;
            }
        }

    }
}
