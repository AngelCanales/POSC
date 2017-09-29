using DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Contexts;

namespace DataBase.Repositories
{
    public class ProductsImageRepository : RepositoryBase<ProductsImage>
    {
        public ProductsImageRepository(POSCContext context) : base(context)
        {
        }

        protected override ProductsImage MapNewValuesToOld(ProductsImage oldEntity, ProductsImage newEntity)
        {
            oldEntity.ProductsId = newEntity.ProductsId;
            oldEntity.Products = newEntity.Products;
            oldEntity.ImageType = newEntity.ImageType;
            oldEntity.Image = newEntity.Image;
            return oldEntity;
        }
    }
}
