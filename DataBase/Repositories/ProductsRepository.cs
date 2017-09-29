using DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Contexts;

namespace DataBase.Repositories
{
    public class ProductsRepository : RepositoryBase<Products>
    {
        public ProductsRepository(POSCContext context) : base(context)
        {
        }

        protected override Products MapNewValuesToOld(Products oldEntity, Products newEntity)
        {
            oldEntity.Description = newEntity.Description;
            oldEntity.ProductsImage = newEntity.ProductsImage;
            oldEntity.Id = newEntity.Id;
            oldEntity.Name = newEntity.Name;
            oldEntity.Price = newEntity.Price;
            oldEntity.ProductsImage = newEntity.ProductsImage;
            oldEntity.ProductsType = newEntity.ProductsType;
            oldEntity.Tax = newEntity.Tax;
            oldEntity.Barcode = newEntity.Barcode;
            oldEntity.Cost = newEntity.Cost;
            oldEntity.Discount = newEntity.Discount;
            oldEntity.Suppliers = newEntity.Suppliers;
            oldEntity.IsActive = newEntity.IsActive;
            oldEntity.ExpirationDate = newEntity.ExpirationDate;
            return oldEntity;
      


        }
    }
}
