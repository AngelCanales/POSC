using DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Contexts;

namespace DataBase.Repositories
{
    public class InvoiceRepository : RepositoryBase<Invoice>
    {
        public InvoiceRepository(POSCContext context) : base(context)
        {
        }

        protected override Invoice MapNewValuesToOld(Invoice oldEntity, Invoice newEntity)
        {
            oldEntity.CorrelativeNumber = newEntity.CorrelativeNumber;
            oldEntity.Description = newEntity.Description;
            oldEntity.DescriptionContinued = newEntity.DescriptionContinued;
            oldEntity.Email = newEntity.Email;
            oldEntity.EmissionDate = newEntity.EmissionDate;
            oldEntity.InvoiceId = newEntity.InvoiceId;
            oldEntity.InvoiceNumber = newEntity.InvoiceNumber;
            oldEntity.Name = newEntity.Name;
            oldEntity.Order = newEntity.Order;
            oldEntity.OrderId = newEntity.OrderId;
            oldEntity.PrintCode = newEntity.PrintCode;
            oldEntity.RTN = newEntity.RTN;
            return oldEntity;
        }
    }
}
