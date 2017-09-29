using DataBase.Contexts;
using DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Repositories
{
  public  class CustomerRepository:RepositoryBase<Customer>
    {
        public CustomerRepository(POSCContext context)
            :base(context)
        {

        }

        protected override Customer MapNewValuesToOld(Customer oldEntity, Customer newEntity)
        {
            oldEntity.Name = newEntity.Name;
            oldEntity.PhoneNumber1 = newEntity.PhoneNumber1;
            oldEntity.PhoneNumber2 = newEntity.PhoneNumber2;
            oldEntity.RTN = newEntity.RTN;
            oldEntity.Address = newEntity.Address;
            oldEntity.Id = newEntity.Id;
            oldEntity.ContactName = newEntity.ContactName;
            return oldEntity;
        }
    }
}
