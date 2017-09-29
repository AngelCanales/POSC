using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
   public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public ICollection<OrderDetail> OrderDetail { get; set; }

        public Customer Customer { get; set; }

        public Employees Employees { get; set; }

        public Store Store { get; set; }

       public string CustomerName { get; set; }

       public string Rtn { get; set; }

        public virtual Invoice Invoice { get; set; }

        public bool IsActive { get; set; }

       

    }
}
