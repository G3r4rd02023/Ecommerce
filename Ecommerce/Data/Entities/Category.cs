using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Categoría")]
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Imagen")]
        public Guid ImageId { get; set; }

        //TODO: Pending to put the correct paths
        [Display(Name = "Imagen")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://localhost:44390/images/noimage.png"
            : $"https://tecnologershn.blob.core.windows.net/categorias/{ImageId}";
    }
}

