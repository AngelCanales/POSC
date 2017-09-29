using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
  public  class Discount
    {
        public int DiscountId { get; set; }

        public string Description { get; set; }

        public decimal Percentage { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
