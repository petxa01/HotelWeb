using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelWeb.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        

        [RegularExpression(@"^[0-9]{8,8}[A-Za-z]{1}$", ErrorMessage = "Not a valid NAN please enter 8 numbers and a proper letter"),Required]
        public string Nan { get; set; }

        [RegularExpression(@"^[a-zA-Z]*$"), Required, StringLength(30)]
        public string Name { get; set; }

        [RegularExpression(@"^[a-zA-Z]*$"), Required, StringLength(30)]
        public string Surname { get; set; }
         
        [Range(typeof(DateTime), "1/1/1886", "1/1/2020"), DataType(DataType.DateTime),Required]
        public DateTime Birthdate { get; set; }

        [DataType(DataType.Password),Required]
        public string Password { get; set; }
        
        [RegularExpression(@"^(([^<>()[\]\\.,;:\s@""]+(\.[^<>()[\]\\.,;:\s@""]+)*)|("".+""))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$", ErrorMessage = "Not a valid email format"),DataType(DataType.EmailAddress),Required]
        public string Email { get; set; }
        
        [RegularExpression(@"^[0-9]{8,11}$", ErrorMessage = "Not a valid Credit card please enter between 13-16 numbers"),DataType(DataType.CreditCard),Display(Name = "Credit Card"),Required]
        public string CreditCard { get; set; }


        public virtual IList<Reservation> Reservations { get; set; }

    }
}
