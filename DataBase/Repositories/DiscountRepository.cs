using DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Contexts;

namespace DataBase.Repositories
{
    public class DiscountRepository : RepositoryBase<Discount>
    {
        public DiscountRepository(POSCContext context) : base(context)
        {
        }

        protected override Discount MapNewValuesToOld(Discount oldEntity, Discount newEntity)
        {
            oldEntity.Description = newEntity.Description;
            oldEntity.DiscountId = newEntity.DiscountId;
            oldEntity.Percentage = newEntity.Percentage;
            oldEntity.Products = newEntity.Products;
            return oldEntity;

        }
    }
}
