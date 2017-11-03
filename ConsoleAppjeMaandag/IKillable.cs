using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppjeMaandag
{
    public interface IKillable
    {
        void Attack(Killable target);

        void TakeDamage(int attackDamage);

    }

    public abstract class Killable : IKillable
    {

        public int HitPoints = 10;

        public int AttackPoints = 1;

        public void Attack(Killable target)
        {
            target.TakeDamage(AttackPoints);
        }

        public void TakeDamage(int attackDamage)
        {
            // Check if hitpoints is higher than the incoming attack damage
            if (HitPoints > attackDamage)
            {
                HitPoints -= attackDamage;
                // Monster attacks player back
                Console.WriteLine("Het monster slaat jouw voor {0} punten aan beschadiging.", AttackPoints);
                Player.HitPoints -= AttackPoints;
            } else
            {
                // DIE!
                Console.WriteLine("Je hebt het monster verslagen!");
                Game.currentRoom.monster = null;
            }
        }
    }
}
