using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Data.Entities
{
    public class City
    {
        public int Id { get; set; }

        [DisplayName("Ciudad")]
        [MaxLength(50)]
        [Required]       
        public string Name { get; set; }

        [NotMapped]
        public int IdCountry { get; set; }

    }

}
