using DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Contexts;

namespace DataBase.Repositories
{
    public class SuppliersRepository : RepositoryBase<Suppliers>
    {
        public SuppliersRepository(POSCContext context) 
            : base(context)
        {
        }

        protected override Suppliers MapNewValuesToOld(Suppliers oldEntity, Suppliers newEntity)
        {
            oldEntity.ContactName = newEntity.ContactName;
            oldEntity.Id = newEntity.Id;
            oldEntity.Name = newEntity.Name;
            oldEntity.PhoneContactName = newEntity.PhoneContactName;
            oldEntity.PhoneSuppliers = newEntity.PhoneSuppliers;
            oldEntity.RTN = newEntity.RTN;
            return oldEntity;
        }
    }
}
