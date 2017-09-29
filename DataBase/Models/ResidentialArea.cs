using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
  public  class ResidentialArea
    {
        public int ResidentialAreaId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Address> Address { get; set; }
    }
}
