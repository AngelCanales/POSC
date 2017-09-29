using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
  public  class PurchasesDetail
    {
        public int ProductsId { get; set; }

        public Products Products { get; set; }

        [Required]
        public int Quantity { get; set; }

        public int IdLine { get; set; }
        public DateTime EntryDate { get; set; }

        public int PurchasesId { get; set; }

        public Purchases Purchases { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public decimal Tax { get; set; }

        [Required]
        public decimal Discount { get; set; }
    }
}
