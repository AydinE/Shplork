using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppjeMaandag
{
    public static class Game
    {

        private static DateTime _startTime { get; set; }
        public static Room currentRoom;

        public static void StartGame()
        {
            Initialize();
            Start();
        }

        public static void End()
        {
            Console.WriteLine("");
            Console.WriteLine("Bedankt voor het spelen van SHPLORK!");
            Console.WriteLine("je uiteindelijke score was: {0}", Player.Level);
            Console.ReadKey();
            Environment.Exit(2);
        }

        private static void Start()
        {
            Console.Clear();

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
                Player.FirstName = firstName;
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
                Player.LastName = lastName;
            }
            else
            {
                Error.ErrorMessage("Geen geldige achternaam.");
                Start();
            }

            Player.Level = 1;

            // Initialize levels
            GameLevels gameLevels = new GameLevels();
            gameLevels.InitializeLevels();

            Console.WriteLine($"Hallo {Player.FirstName} van de familie {Player.LastName}, je huidige level is {Player.Level}. ");
            
            // Initialize command helper
            CommandHandler commandHandler = new CommandHandler();
            commandHandler.GetCommand();

        }

        private static void GetCommand()
        {
            

            GetCommand();

        }

        private static void Initialize()
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
