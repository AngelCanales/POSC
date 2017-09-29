using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.AspNet.Identity.EntityFramework;
    

    public class Customer
    {
        [Key]

        public int Id { get; set; }

        public string Name { get; set; }

        public Address Address { get; set; }

        public string RTN { get; set; }

        public string PhoneNumber1 { get; set; }

        public string PhoneNumber2 { get; set; }

        public string ContactName { get; set; }

    }
}
