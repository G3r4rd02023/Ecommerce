using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class Departments
    {
       [Key]
        public int DepartmentId { get; set; }

        
        [Required(ErrorMessage = "El Campo es requerido")]
        [StringLength(30, ErrorMessage =
     "The field {0} can contain maximun {1} and minimum {2} characters",
     MinimumLength = 3)]
        [Display(Name = "Depto")]
        public string Name { get; set; }



    }
}