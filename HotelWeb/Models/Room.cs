using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelWeb.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        
        [Range(100,1000),Required]
        public int RoomNumber { get; set; }

        [Display(Name = "Hotel")]
        public int HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }

        [Range(1,4),Required]
        public int Capacity { get; set; }

        [DataType(DataType.Currency),Required]
        public float Price { get; set; }


    }
}
