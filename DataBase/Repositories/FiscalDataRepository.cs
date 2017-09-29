using DataBase.Contexts;
using DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Repositories
{
    class FiscalDataRepository:RepositoryBase<FiscalData>
    {
        public FiscalDataRepository(POSCContext context)
            :base(context)
        {

        }

        protected override FiscalData MapNewValuesToOld(FiscalData oldEntity, FiscalData newEntity)
        {
            oldEntity.CurrenInvoiceNumber = newEntity.CurrenInvoiceNumber;
            oldEntity.DocumentType = newEntity.DocumentType;
            oldEntity.EmissionPoint = newEntity.EmissionPoint;
            oldEntity.Establishment = newEntity.Establishment;
            oldEntity.FirstInvoiceNumber = newEntity.FirstInvoiceNumber;
            oldEntity.Id = newEntity.Id;
            oldEntity.LastInvoiceNumber = newEntity.LastInvoiceNumber;
            oldEntity.PrintCode = newEntity.PrintCode;
            oldEntity.ValidUntilDate = newEntity.ValidUntilDate;
            oldEntity.Store = newEntity.Store;
            return oldEntity;
        }
    }
}
