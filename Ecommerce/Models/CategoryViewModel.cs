using Ecommerce.Data.Entities;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class CategoryViewModel:Category
    {
        [Display(Name = "Imagen")]
        public IFormFile ImageFile { get; set; }
    }
}
