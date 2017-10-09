using DataBase.Contexts;
using DataBase.Models;
using DataBase.Repositories;
using DataBase.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
   public class EmployeesLogic
    {
        private POSCContext context;
        private POSCUnitOfWork unitofwork;
      
  
        public EmployeesLogic()
        {
            this.context = new POSCContext();
            this.unitofwork = new POSCUnitOfWork(context);
        }

        public async Task CreateAsync(Employees employees)
        {
            unitofwork.EmployeesRepository.Create(employees);
            await unitofwork.SaveChangesAsync();
        }
        public void SaveChangesAsync()
        {
            unitofwork.SaveChangesAsync();
        }

        public void UpdateEmployees(Employees employees)
        {
            unitofwork.EmployeesRepository.Update(employees);
        }

        public async Task DeleteEmployeesAsync(string id)
        {
            var employees = await unitofwork.EmployeesRepository.FirstOrDefaultAsync(d => d.UserId == id);
        
            unitofwork.EmployeesRepository.Delete(employees);
            await unitofwork.SaveChangesAsync();
        }
    }
}
