using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sitech.Models
{
    public class ProductType
    {
        [Key]
        public int ProductTypeId { get; set; }
        [StringLength(70, ErrorMessage = "No debe de tener mas de 70 caracteres...")]
        [Display(Name = "Descripcion del tipo")]
        [Required]
        [MinLength(3, ErrorMessage = "Debe de tener mas de tres caracteres...")]
        public string ProductTypeDescription { get; set; }
        //relacion de uno a muchos
        public IEnumerable<Product> Products { get; set; }

    }
}
