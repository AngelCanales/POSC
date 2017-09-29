using DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Contexts;

namespace DataBase.Repositories
{
    public class EmployeesRepository : RepositoryBase<Employees>
    {
        public EmployeesRepository(POSCContext context) 
            : base(context)
        {
        }

        protected override Employees MapNewValuesToOld(Employees oldEntity, Employees newEntity)
        {
            oldEntity.Address = newEntity.Address;
            oldEntity.ContactName = newEntity.ContactName;
            oldEntity.EmployeesType = newEntity.EmployeesType;
            oldEntity.Name = newEntity.Name;
            oldEntity.PhoneNumber1 = newEntity.PhoneNumber1;
            oldEntity.PhoneNumber2 = newEntity.PhoneNumber2;
            oldEntity.RTN = newEntity.RTN;
            oldEntity.User = newEntity.User;
            oldEntity.UserId = newEntity.UserId;
            return oldEntity;

        }
    }
}
