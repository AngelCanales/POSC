using DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Contexts;

namespace DataBase.Repositories
{
    public class OrderDetailRepository : RepositoryBase<OrderDetail>
    {
        public OrderDetailRepository(POSCContext context) 
            : base(context)
        {
        }

        protected override OrderDetail MapNewValuesToOld(OrderDetail oldEntity, OrderDetail newEntity)
        {
            oldEntity.DateStrig = newEntity.DateStrig;
            oldEntity.DeliveryDate = newEntity.DeliveryDate;
            oldEntity.Order = newEntity.Order;
            oldEntity.OrderId = newEntity.OrderId;
            oldEntity.Price = newEntity.Price;
            oldEntity.Products = newEntity.Products;
            oldEntity.ProductsId = newEntity.ProductsId;
            oldEntity.Quantity = newEntity.Quantity;
            oldEntity.Tax = newEntity.Tax;
            oldEntity.TimeString = newEntity.TimeString;
            oldEntity.IdLine = newEntity.IdLine;
            return oldEntity;
        }
    }
}
