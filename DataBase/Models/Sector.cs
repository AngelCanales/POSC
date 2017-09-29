using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    public class Sector
    {
        public int SectorId { get; set; }

        public string Name { get; set; }

        public string Abbreviation { get; set; }

        public virtual ICollection<Address> Address { get; set; }
    }
}
