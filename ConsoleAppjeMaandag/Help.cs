using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppjeMaandag
{
    class Help
    {

        public static void Helper()
        {
            Console.Clear();
            Console.WriteLine(@"

                 _________________________________________________________
                |----------------------- ~ Help ~ ------------------------|
                |---------------------------------------------------------|
                |  De volgende commando's zijn te gebruiken in SHPLORK.   | 
                |                                                         |  
                |    - Suicide - Beëindigt het huidige spel.              |
                |    - Help - Weergeeft dit menu.                         |
                |    - Move - Verplaats jezelf naar een kamer             |
                |       - North - Ga naar de kamer noord van hier.        |
                |       - East - Ga naar de kamer noord van hier.         |
                |       - South - Ga naar de kamer noord van hier.        |
                |       - West - Ga naar de kamer noord van hier.         |
                |    - Look - Kijk rond in de huidige kamer.              |
                |    - Attack <monster-naam> val een monster aan.         |
                |      gebruikt automatisch eventuele wapens in inventory.|
                |_________________________________________________________|    


            ");
        }


    }
}
