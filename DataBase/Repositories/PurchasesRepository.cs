using DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Contexts;

namespace DataBase.Repositories
{
    public class PurchasesRepository : RepositoryBase<Purchases>
    {
        public PurchasesRepository(POSCContext context) 
            : base(context)
        {
        }

        protected override Purchases MapNewValuesToOld(Purchases oldEntity, Purchases newEntity)
        {
            oldEntity.DateOfPurchase = newEntity.DateOfPurchase;
            oldEntity.Employees = newEntity.Employees;
            oldEntity.Id = newEntity.Id;
            oldEntity.Suppliers = newEntity.Suppliers;
            oldEntity.PurchasesDetail = newEntity.PurchasesDetail;
            return oldEntity;

        }
    }
}
