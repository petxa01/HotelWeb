using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelWeb.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$"), Required, StringLength(30)]
        public string Name { get; set; }

        public virtual IList<City> Cities { get; set; }

    }
}
