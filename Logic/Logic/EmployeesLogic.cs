using DataBase.Contexts;
using DataBase.Models;
using DataBase.Repositories;
using DataBase.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

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

        public void CreateUser(string email, string password)
        {
            var user = new ApplicationUser
            {
                UserName = email,
                Email = email,
            };
            var userManger = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var result = userManger.Create(user, password);
            unitofwork.SaveChanges();


        }

        public string RolesGET(string typeEmployee)
        {
            string roles = "StoreCashier";
            if (typeEmployee == "Administrator") { roles = "Administrator"; };
            return roles;
        }
        public bool verifypassword(string password1, string password2)
        {
            if (password1 == password2) { return true; }
            return false;
        }


        public ApplicationUser AddToRoleUser(string role ,string email)
        {
            var userManger = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var users = userManger.FindByEmail(email);
            userManger.AddToRole(users.Id, role);
            unitofwork.SaveChanges();
            return users;
        }
        public void Create(Employees employees,string email ,string password,string roles)
        {
            CreateUser(email, password);
            var user = AddToRoleUser(roles, email);
            var EmployeesATM = new Employees
            {
                User = user,
                EmployeesType = employees.EmployeesType,
                Store = employees.Store,

            };
            employees.User = user;
            employees.UserId = user.Id;
            unitofwork.EmployeesRepository.Create(EmployeesATM);
            unitofwork.SaveChanges();

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
