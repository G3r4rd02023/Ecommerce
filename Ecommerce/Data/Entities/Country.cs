using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [DisplayName("País")]
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [DisplayName("No. Ciudades")]
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;


        public ICollection<City> Cities { get; set; }
    }

}
