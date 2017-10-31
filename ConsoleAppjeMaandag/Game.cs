using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppjeMaandag
{
    public class Game
    {

        private string _startTime { get; set; }

        public void StartGame()
        {
            Initialize();
            Start();
        }

        private void End()
        {
            Console.WriteLine("");
            Console.WriteLine("Bedankt voor het spelen van SHPLORK!");
            Console.ReadKey();
            Environment.Exit(2);
        }

        private void Start()
        {
            Console.Clear();
            Player player = new Player();

            Console.WriteLine(@"
                  _  _ _                       ___           _         
                 | \| (_)___ _  ___ __ _____  / __|_ __  ___| |___ _ _ 
                 | .` | / -_) || \ V  V / -_) \__ \ '_ \/ -_) / -_) '_|
                 |_|\_|_\___|\_,_|\_/\_/\___| |___/ .__/\___|_\___|_|  
                                                  |_|                  

            ");
           

            Console.WriteLine("");
            Console.WriteLine("Geef een voornaam: ");
            string firstName = Console.ReadLine();
            if (firstName.Length > 0)
            {
                player.FirstName = firstName;
            }
            else
            {
                Error.ErrorMessage("Geen geldige voornaam.");
                Start();
            }
            Console.WriteLine("Geef een achternaam: ");
            string lastName = Console.ReadLine();
            if (lastName.Length > 0)
            {
                player.LastName = lastName;
            }
            else
            {
                Error.ErrorMessage("Geen geldige achternaam.");
                Start();
            }           

            Console.WriteLine($"Hallo {player.FirstName} van de familie {player.LastName}, je huidige level is {player.Level}. ");

            GetCommand();
        }

        private void GetCommand()
        {
            string command = Console.ReadLine();

            switch (command)
            {
                case "help":
                    Help.Helper();
                    break;
                case "suicide":
                    End();
                    break;
                default:
                    Console.WriteLine("Geen geldig commando, voer \"help\" in voor een lijst met geldige commando's");
                    break;
            }

            GetCommand();

        }

        private void Initialize()
        {

            Console.WriteLine(@"
                  _________ ___ _____________.____    ________ __________ ____  __.
                 /   _____//   |   \______   \    |   \_____  \\______   \    |/ _|
                 \_____  \/    ~    \     ___/    |    /   |   \|       _/      <  
                 /        \    Y    /    |   |    |___/    |    \    |   \    |  \ 
                /_______  /\___|_  /|____|   |_______ \_______  /____|_  /____|__ \
                            \/       \/                  \/       \/       \/        \/
             --.____.--~~~~~~--.____.--~~~~~~--.____.--~~~~~~--.____.--~~~~~~--.____.--
                        ____            ____            ____            ____
             '.      .'~    ~'.      .'~    ~'.      .'~    ~'.      .'~    ~'.      .'
               \    /          \    /          \    /          \    /          \    /
                Y  Y            Y  Y            Y  Y            Y  Y            Y  Y
                |  |            |  |            |  |            |  |            |  |
                |  |            |  |            |  |            |  |            |  |
                |  |            |  |            |  |            |  |            |  |
                |__|            |__|            |__|            |__|            |__|

            ");
            Console.WriteLine(@"                  Welkom in SHPLORK, druk op een toets om een nieuw spel te starten!");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
