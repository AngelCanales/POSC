using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
  public  class Suppliers
    {
        [Key]
        public int Id  { get; set; }

        public string Name { get; set; }

        public string RTN { get; set; }

        public string ContactName { get; set; }

        public string PhoneContactName { get; set; }

        public string PhoneSuppliers { get; set; }
    }
}
