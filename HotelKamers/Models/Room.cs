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

        [StringLength(60, MinimumLength = 5)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Available from")]
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime AvailableFrom { get; set; }

        [Range(0, 1)]
        [Required]
        public RoomType Type { get; set; }
    }
}
