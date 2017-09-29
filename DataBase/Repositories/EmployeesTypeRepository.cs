using DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Contexts;

namespace DataBase.Repositories
{
    public class EmployeesTypeRepository : RepositoryBase<EmployeesType>
    {
        public EmployeesTypeRepository(POSCContext context) : base(context)
        {
        }

        protected override EmployeesType MapNewValuesToOld(EmployeesType oldEntity, EmployeesType newEntity)
        {
            oldEntity.Description = newEntity.Description;
            oldEntity.Id = newEntity.Id;
            oldEntity.Name = newEntity.Name;
            return oldEntity;
        }
    }
}
