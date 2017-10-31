using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppjeMaandag
{
    class Error
    {

        public static void ErrorMessage(String error)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();

            Console.WriteLine(@"
                 ________ ________  ___  ___  _________   
                |\  _____\\   __  \|\  \|\  \|\___   ___\ 
                \ \  \__/\ \  \|\  \ \  \\\  \|___ \  \_| 
                 \ \   __\\ \  \\\  \ \  \\\  \   \ \  \  
                  \ \  \_| \ \  \\\  \ \  \\\  \   \ \  \ 
                   \ \__\   \ \_______\ \_______\   \ \__\
                    \|__|    \|_______|\|_______|    \|__|        



                        Je bent een mislukkeling
                           {0}


            ", error);

            System.Threading.Thread.Sleep(4000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

        }

    }
}
