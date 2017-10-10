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
  public  class EmployeesTypeLogic
    {
        private POSCContext context;
        private POSCUnitOfWork unitofwork;
        public EmployeesTypeLogic()
        {
            this.context = new POSCContext();
            this.unitofwork = new POSCUnitOfWork(context);
        }

        public ICollection<EmployeesType> GetAll()
        {
            return unitofwork.EmployeesTypeRepository.All().ToList();
        }

        public  EmployeesType GetEmployeesType(int id)
        {
            return unitofwork.EmployeesTypeRepository.Find(id);
        }
        public async Task<EmployeesType> GetEmployeesTypeAsync(int id)
        {
            return await unitofwork.EmployeesTypeRepository.FindAsync(id);
        }
    }
}
