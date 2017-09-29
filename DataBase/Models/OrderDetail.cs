using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   public class OrderDetail
    {
        public int ProductsId { get; set; }

        public Products Products { get; set; }

        [Required]
        public int Quantity { get; set; }

        public int IdLine { get; set; }
        public DateTime DeliveryDate { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public decimal Tax { get; set; }

        public string DateStrig { get; set; }

        public string TimeString { get; set; }
    }
}
