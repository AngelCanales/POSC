using DataBase.Contexts;
using DataBase.Models;
using DataBase.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
   public class StoreLogic
    {
        private POSCContext context;
        private POSCUnitOfWork unitofwork;

        public StoreLogic()
        {
            this.context = new POSCContext();
            this.unitofwork = new POSCUnitOfWork(context);
        }

        public ICollection<Store> GetAll()
        {
            return unitofwork.StoreRepository.All().ToList();
        }
    }
}
