using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelWeb.Models
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }

        [Range(50,2000),Required]
        public int NumberOfRooms { get; set; }

        [Range(1, 5),Required]
        public int NumberOfStars { get; set; }

        [Required]
        public string Address { get; set; }
        public string Image { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "City")]
        public int CityId { get; set; }
        public virtual City City { get; set; }

        public virtual IList<Room> Rooms { get; set; }

        public virtual IList<Reservation> Reservations { get; set; }

        public virtual IList<Hotel> Hotels { get; set; }


    }
}
