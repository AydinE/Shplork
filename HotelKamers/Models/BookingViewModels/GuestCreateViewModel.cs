using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelKamers.Models.BookingViewModels
{
    public class GuestCreateViewModel
    {

        [Required]
        public RoomType RoomType { get; set; }

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
