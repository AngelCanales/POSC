using DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Contexts;

namespace DataBase.Repositories
{
    public class OrderNumberRepository : RepositoryBase<OrderNumber>
    {
        public OrderNumberRepository(POSCContext context) 
            : base(context)
        {
        }

        protected override OrderNumber MapNewValuesToOld(OrderNumber oldEntity, OrderNumber newEntity)
        {
            oldEntity.CurrenNumber = newEntity.CurrenNumber;
            oldEntity.Id = newEntity.Id;
            oldEntity.LastNumber = newEntity.LastNumber;
            return oldEntity;

        }
    }
}
