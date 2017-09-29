using DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Contexts;

namespace DataBase.Repositories
{
    public class TaxRepository : RepositoryBase<Tax>
    {
        public TaxRepository(POSCContext context) : base(context)
        {
        }

        protected override Tax MapNewValuesToOld(Tax oldEntity, Tax newEntity)
        {
            oldEntity.Description = newEntity.Description;
            oldEntity.Percentage = newEntity.Percentage;
            oldEntity.Products = newEntity.Products;
            oldEntity.TaxId = newEntity.TaxId;
            return oldEntity;
        }
    }
}
