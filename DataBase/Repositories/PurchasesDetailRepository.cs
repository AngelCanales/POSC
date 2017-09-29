using DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Contexts;

namespace DataBase.Repositories
{
    public class PurchasesDetailRepository : RepositoryBase<PurchasesDetail>
    {
        public PurchasesDetailRepository(POSCContext context) : base(context)
        {
        }

        protected override PurchasesDetail MapNewValuesToOld(PurchasesDetail oldEntity, PurchasesDetail newEntity)
        {
            oldEntity.Discount = newEntity.Discount;
            oldEntity.EntryDate = newEntity.EntryDate;
            oldEntity.IdLine = newEntity.IdLine;
            oldEntity.Price = newEntity.Price;
            oldEntity.Products = newEntity.Products;
            oldEntity.ProductsId = newEntity.ProductsId;
            oldEntity.Purchases = newEntity.Purchases;
            oldEntity.PurchasesId = newEntity.PurchasesId;
            oldEntity.Quantity = newEntity.Quantity;
            oldEntity.Tax = newEntity.Tax;
            return oldEntity;
        }
    }
}
