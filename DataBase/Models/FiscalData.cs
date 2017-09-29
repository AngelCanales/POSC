using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
  public  class FiscalData
    {
        [Key]
        public int Id { get; set; }

        public int EmissionPoint { get; set; }

        public int Establishment { get; set; }


        public int DocumentType { get; set; }

        public int CurrenInvoiceNumber { get; set; }

        public int FirstInvoiceNumber { get; set; }

        public int LastInvoiceNumber { get; set; }

        public string PrintCode { get; set; }

        public DateTime ValidUntilDate { get; set; }

        public Store Store { get; set; }

    }
}
