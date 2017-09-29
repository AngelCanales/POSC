using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
 public   class Invoice
    {
        public int InvoiceId { get; set; }

        public string InvoiceNumber { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string DescriptionContinued { get; set; }

        public string RTN { get; set; }

        public string Email { get; set; }

        public DateTime EmissionDate { get; set; }

        public string PrintCode { get; set; }

        public int CorrelativeNumber { get; set; }

        [Key]
        [Column(Order = 1)]
        [ForeignKey(nameof(Order))]
        public int OrderId { get; set; }

        public Order Order { get; set; }
    }
}
