using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
   public class Products
    {
        [Key]
        public int Id { get; set; }

        public string Barcode { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public bool IsActive { get; set; }

        public ProductsImage ProductsImage { get; set; }

        [Required]
        public ProductsType ProductsType { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }

        [Required]
        public Tax Tax { get; set; }

        [Required]
        public Discount Discount { get; set; }

        [Required]
        public Suppliers Suppliers { get; set; }

        public int Cost { get; set; }

        public DateTime ExpirationDate { get; set; }

    }
}
