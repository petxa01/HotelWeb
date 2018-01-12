using System;
using System.ComponentModel.DataAnnotations;

namespace HotelWeb.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Customer")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        [Display(Name = "Room Number")]
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }

        [DataType(DataType.Date),Required]
        public DateTime EntryDate { get; set; }

        [DataType(DataType.Date),Required]
        public DateTime DepartureDate { get; set; }

        



    }
}
