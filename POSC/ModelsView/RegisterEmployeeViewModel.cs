using DataBase.Models;
using Logic.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSC.ModelsView
{
public  class RegisterEmployeeViewModel
    {
       
       
     
        public int EmployeesTypeID { get; set; }
        public ICollection<EmployeesType> EmployeesType { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
        public string RTN { get; set; }

        public string PhoneNumber1 { get; set; }

        public string PhoneNumber2 { get; set; }

        public string ContactName { get; set; }

        public int StoreId { get; set; }

        public ICollection<Store> Store { get; set; }

        public int SectorID { get; set; }
        [Required]
        public ICollection<Sector> Sector { get; set; }

        public int ResidentialAreaID { get; set; }
        [Required]
        public ICollection<ResidentialArea> ResidentialArea { get; set; }

        public string Street { get; set; }

        public string Avenue { get; set; }

        public string Boulevard { get; set; }

        public string References { get; set; }
    }
}
