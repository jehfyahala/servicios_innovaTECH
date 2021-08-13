using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sitech.Models
{
    public class Product
    {

        [Key]
        public int ProductId { get; set; }
        [StringLength(70, ErrorMessage = "No debe de tener mas de 70 caracteres...")]
        [Display(Name = "Descripcion del producto")]
        [Required]
        [MinLength(3, ErrorMessage = "Debe de tener mas de tres caracteres...")]
        public string ProductDescription { get; set; }
        [Display(Name = "Stock")]
        [Required]
        public int ProductStock { get; set; }
        [Column(TypeName ="decimal(12,2)")]
        [Display(Name = "Valor")]
        [Required]
        public decimal Value { get; set; }

        [Display(Name = "Tipo de producto")]
        public int ProductTypeId { get; set; }
        [ForeignKey("ProductTypeId")]
        public ProductType ProductType { get; set; }

        //public IEnumerable<ProductType> ProductTypes { get; set; }
    }
}
