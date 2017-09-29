using DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Contexts;

namespace DataBase.Repositories
{
    public class OrderRepository : RepositoryBase<Order>
    {
        public OrderRepository(POSCContext context) 
            : base(context)
        {
        }

        protected override Order MapNewValuesToOld(Order oldEntity, Order newEntity)
        {
            oldEntity.OrderDetail = newEntity.OrderDetail;
            oldEntity.OrderId = newEntity.OrderId;
            oldEntity.Customer = newEntity.Customer;
            oldEntity.CustomerName = newEntity.CustomerName;
            oldEntity.Employees = newEntity.Employees;
            oldEntity.Invoice = newEntity.Invoice;
            oldEntity.IsActive = newEntity.IsActive;
            oldEntity.Rtn = newEntity.Rtn;
            oldEntity.Store = newEntity.Store;
            return oldEntity;
        }
    }
}
