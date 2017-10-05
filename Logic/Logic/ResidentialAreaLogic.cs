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
  public  class ResidentialAreaLogic
    {
        private POSCContext context;
        private POSCUnitOfWork unitofwork;
        public ResidentialAreaLogic()
        {

            this.context = new POSCContext();
            this.unitofwork = new POSCUnitOfWork(context);
        }

        public ICollection<ResidentialArea> GetAll()
        {
            return unitofwork.ResidentialAreaRepository.All().ToList();
        }
    }
}
