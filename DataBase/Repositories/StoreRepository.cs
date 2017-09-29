using DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Contexts;

namespace DataBase.Repositories
{
    public class StoreRepository : RepositoryBase<Store>
    {
        public StoreRepository(POSCContext context) : base(context)
        {
        }

        protected override Store MapNewValuesToOld(Store oldEntity, Store newEntity)
        {
            oldEntity.Address = newEntity.Address;
            oldEntity.Description = newEntity.Description;
            oldEntity.Id = newEntity.Id;
            oldEntity.Name = newEntity.Name;
            return oldEntity;
        }
    }
}
