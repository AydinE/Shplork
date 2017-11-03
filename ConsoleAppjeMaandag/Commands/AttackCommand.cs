using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppjeMaandag.Commands
{
    class AttackCommand
    {

        public static void Attack(string subCommand)
        {

            if (Game.currentRoom.monster == null)
            {
                Console.WriteLine("Er is hier niets met de naam {0} dat je kunt aanvallen.", subCommand);
                return;
            }

            string ignoredCase = subCommand.ToLower();

            String name = Game.currentRoom.monster.GetType().Name;
            String nameLower = name.ToLower();

            if (nameLower.Equals(subCommand.ToLower()))
            {
                
                Console.WriteLine("Je hebt de {0} geslagen voor {1} punten.", name, Player.AttackPoints);
                Console.WriteLine("De {0} heeft nog {1} leven.", name, Game.currentRoom.monster.HitPoints);
                Game.currentRoom.monster.TakeDamage(Player.AttackPoints);

            }
            else
            {
                Console.WriteLine("Er is hier niets met de naam {0} dat je kunt aanvallen.", subCommand);
            }
            
        }

    }
}
