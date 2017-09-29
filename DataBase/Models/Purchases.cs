using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
   public  class Purchases
    {
        [Key]
        public int Id { get; set; }

        public ICollection<PurchasesDetail> PurchasesDetail { get; set; }

        public Suppliers Suppliers { get; set; }

        public DateTime DateOfPurchase { get; set; }

        public Employees Employees { get; set; }

    }
}
