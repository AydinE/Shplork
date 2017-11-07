using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelKamers.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public Room Room { get; set; }
        [Required]
        public int RoomId { get; set; }

        public ApplicationUser Guest { get; set; }
        [Required]
        public string GuestId { get; set; }

        [Display(Name = "From: ")]
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime StartDateTime { get; set; }

        [Display(Name = "To: ")]
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime EndDateTime { get; set; }
    }
}
