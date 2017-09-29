using DataBase.Contexts;
using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.UnitOfWork;
using DataBase.Models;

namespace Logic.Logic
{
   public class FiscalDataLogic
    {
        private POSCContext context;
        private POSCUnitOfWork unitofwork;

        public FiscalDataLogic()
        {
            this.context = new POSCContext();
            this.unitofwork = new POSCUnitOfWork(context);
        }

        public async Task<FiscalData> GetAllDataFiscalAsync()
        {
            return await unitofwork.FiscalDataRepository.FirstOrDefaultAsync(f => true);
        }

        public async Task<FiscalData> GetAllfiscalDataFind(int id)
        {

            return await unitofwork.FiscalDataRepository.FindAsync(id);
        }

        public async Task SaveChangesAsync(FiscalData fiscal)
        {
            var fiscaldata = await GetAllfiscalDataFind(fiscal.Id);
            fiscaldata.LastInvoiceNumber = fiscal.LastInvoiceNumber;
            fiscaldata.FirstInvoiceNumber = fiscal.FirstInvoiceNumber;
            fiscaldata.ValidUntilDate = fiscal.ValidUntilDate;
            fiscaldata.CurrenInvoiceNumber = fiscal.CurrenInvoiceNumber;
            fiscaldata.PrintCode = fiscal.PrintCode;
            await unitofwork.SaveChangesAsync();
        }
    }
}
