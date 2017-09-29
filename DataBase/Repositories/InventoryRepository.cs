using DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Contexts;

namespace DataBase.Repositories
{
    public class InventoryRepository : RepositoryBase<Inventory>
    {
        public InventoryRepository(POSCContext context) 
            : base(context)
        {
        }

        protected override Inventory MapNewValuesToOld(Inventory oldEntity, Inventory newEntity)
        {
            oldEntity.Existence = newEntity.Existence;
            oldEntity.Id = newEntity.Id;
            oldEntity.Products = newEntity.Products;
            oldEntity.Store = newEntity.Store;
            return oldEntity;

        }
    }
}
