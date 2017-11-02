using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppjeMaandag
{
    public class Room
    {

        public Room NorthConnection = null;
        public Room EastConnection = null;
        public Room SouthConnection = null;
        public Room WestConnection = null;

        public string RoomName { get; set; }
        public string Description { get; set; }

    }
}
