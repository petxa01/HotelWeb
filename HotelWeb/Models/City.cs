using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelWeb.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$"), Required, StringLength(30)]
        public string Name { get; set; }

        [RegularExpression(@"^(?!0+$)[0-9]{5,5}$", ErrorMessage = "Not a correct Zip Code format"),Display(Name = "Zip Code"),Required]
        public int ZipCode { get; set; }

        [Display(Name = "Country")]
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        public virtual IList<Hotel> Hotels { get; set; }

    }
}
