using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
   public class Employees
    {
        [Key]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public EmployeesType EmployeesType { get; set; }

        public string Name { get; set; }

        public Address Address { get; set; }

        public string RTN { get; set; }

        public string PhoneNumber1 { get; set; }

        public string PhoneNumber2 { get; set; }

        public string ContactName { get; set; }

        public Store Store { get; set; }

    }
}
