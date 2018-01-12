using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelWeb.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [RegularExpression(@"^[0-9]{8,8}[A-Za-z]{1}$", ErrorMessage = "Not a valid NAN please enter 8 numbers and a proper letter"), Required]
        public string Nan { get; set; }

        [RegularExpression(@"^[a-zA-Z]*$"), Required, StringLength(30)]
        public string Name { get; set; }

        [RegularExpression(@"^[a-zA-Z]*$"), Required, StringLength(30)]
        public string Surname { get; set; }

        [DataType(DataType.Date), Required]
        public DateTime Birthdate { get; set; }

        [DataType(DataType.Date), Required]
        public DateTime ContractStartDate { get; set; }

        [DataType(DataType.Date), Required]
        public DateTime ContractEndDate { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9]{20}$", ErrorMessage = "Not a valid Social security number"),Required]
        public int SocialSecurityNumber { get; set; }

        [Display(Name = "Hotel")]
        public int HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }


    }
}
