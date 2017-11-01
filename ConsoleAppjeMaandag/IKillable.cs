using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppjeMaandag
{
    interface IKillable
    {
        void Attack(Killable target);

        void TakeDamage(int attackDamage);

        void Move(EDirections direction);

    }

    abstract class Killable : IKillable
    {

        public int HitPoints = 10;

        public int AttackPoints = 1;

        public void Attack(Killable target)
        {
            target.TakeDamage(AttackPoints);
        }

        public void Move(EDirections direction)
        {
            // The entity can move to a different room.
        }

        public void TakeDamage(int attackDamage)
        {
            // Check if hitpoints is higher than the incoming attack damage
            if (HitPoints > attackDamage)
            {
                HitPoints -= attackDamage;
            } else
            {
                // DIE!
                Console.WriteLine("Bedankt voor het spelen van SHPLORK!");
                Console.ReadKey();
                Environment.Exit(2);
            }
        }
    }
}
