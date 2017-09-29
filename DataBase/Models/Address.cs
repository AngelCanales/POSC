using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
 public class Address
    {
        public int Id { get; set; }

        [Required]
        public Sector Sector { get; set; }

        [Required]
        public ResidentialArea ResidentialArea { get; set; }

        public string Street { get; set; }

        public string Avenue { get; set; } 

        public string Boulevard { get; set; }

        public string DeliverTo { get; set; }

        public string DeliverPhone { get; set; }

        public string References { get; set; }
    }
}
