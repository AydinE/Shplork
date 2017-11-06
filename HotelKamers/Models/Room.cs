using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelKamers.Models
{
    public class Room
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [Display(Name = "Available from")]
        [DataType(DataType.Date)]
        public DateTime AvailableFrom { get; set; }
        public RoomType Type { get; set; }
    }
}
