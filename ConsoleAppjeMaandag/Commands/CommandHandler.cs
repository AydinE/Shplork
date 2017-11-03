using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppjeMaandag
{
    class CommandHandler
    {
        public void GetCommand()
        {
            string command = Console.ReadLine();

            String[] substrings = command.Split(" ");

            switch (substrings[0])
            {
                case "help":
                    Help.Helper();
                    break;
                case "suicide":
                    Game.End();
                    break;
                case "move":
                    if (substrings.Length > 1) Commands.MoveCommand.Move(substrings[1]);
                    else Console.WriteLine("Geen geldige richting opgegeven voor 'Move' !");
                    break;
                case "attack":
                    if (substrings.Length > 1) Commands.AttackCommand.Attack(substrings[1]);
                    else Console.WriteLine("Geef een target voor je attack !");
                    break;
                default:
                    Console.WriteLine("Geen geldig commando, voer \"help\" in voor een lijst met geldige commando's");
                    break;
            }

            GetCommand();

        }
    }
}
