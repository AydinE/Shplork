using System;

namespace ConsoleAppjeMaandag
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(95, 25);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Game game = new Game();
            game.StartGame();
            Console.ReadKey();
        }

    }
}
