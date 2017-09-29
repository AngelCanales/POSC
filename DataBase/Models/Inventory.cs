using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
  public  class Inventory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Store Store { get; set; }

        [Required]
        public Products Products { get; set; }

        public int Existence  { get; set; }

     
    }
}
