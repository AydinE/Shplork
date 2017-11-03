using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppjeMaandag
{
    class GameLevels
    {
        // Create rooms

        public Room courtyard = new Room
        {
            RoomName = "Courtyard",
            Description = "This is the courtyard",

        };

        public Room castleEntrance = new Room
        {
            RoomName = "Castle Entrance",
            Description = "This is the castle entrance",

        };

        // Initialize 
        public void InitializeLevels()
        {

            Game.currentRoom = courtyard;

            courtyard.NorthConnection = castleEntrance;
            castleEntrance.SouthConnection = courtyard;

            Game.currentRoom.monster = new Monsters.Spider();

        }


    }
}
