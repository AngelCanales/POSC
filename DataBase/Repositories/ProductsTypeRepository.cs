using DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Contexts;

namespace DataBase.Repositories
{
    public class ProductsTypeRepository : RepositoryBase<ProductsType>
    {
        public ProductsTypeRepository(POSCContext context) : base(context)
        {
        }

        protected override ProductsType MapNewValuesToOld(ProductsType oldEntity, ProductsType newEntity)
        {
            oldEntity.Description = newEntity.Description;
            oldEntity.Id = newEntity.Id;
            oldEntity.Image = oldEntity.Image;
            oldEntity.IsAdditional = newEntity.IsAdditional;
            oldEntity.Name = oldEntity.Name;
            return oldEntity;
        }
    }
}
