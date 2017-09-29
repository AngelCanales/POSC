using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    public class OrderNumber
    {
        [Key]
        public int Id { get; set; }

        public int CurrenNumber { get; set; }

        public int LastNumber { get; set; }
    }
}
