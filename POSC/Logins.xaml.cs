using DataBase.Models;
using Logic.Logic;
using POSC.Initializer;
using POSC.ModelsView;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System.Windows.Controls;

using POSC.View;
using Microsoft.AspNet.Identity.EntityFramework;
using DataBase.Contexts;

namespace POSC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly LoginViewModeL loginViewModeL;
        UserManager<IdentityUser> userManager;

        private readonly RegisterEmployeeViewModel registerEmployeeViewModel;
        private readonly EmployeesTypeLogic employeesTypeLogic;
        private readonly StoreLogic storeLogic;
        private readonly ResidentialAreaLogic residentialAreaLogic;
        private readonly SectorLogic sectorLogic;

        public MainWindow(EmployeesTypeLogic employeesTypeLogic, StoreLogic storeLogic, ResidentialAreaLogic residentialAreaLogic, SectorLogic sectorLogic)
        {

            this.sectorLogic = sectorLogic;
            this.residentialAreaLogic = residentialAreaLogic;
            this.storeLogic = storeLogic;
            this.employeesTypeLogic = employeesTypeLogic;
            var x = sectorLogic.GetAll();
            this.registerEmployeeViewModel = new RegisterEmployeeViewModel();
            registerEmployeeViewModel.Sector = x;
            registerEmployeeViewModel.Store = storeLogic.GetAll();
            registerEmployeeViewModel.ResidentialArea =  residentialAreaLogic.GetAll();
            registerEmployeeViewModel.EmployeesType = employeesTypeLogic.GetAll();

            userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(new IdentityDbContext("POSC")));
            this.loginViewModeL = new LoginViewModeL();
            this.DataContext = loginViewModeL;
            InitializeComponent();
        }

        public void Login()
        {

            var user = userManager.Find(loginViewModeL.Email, loginViewModeL.Password);
            
            if (user != null)
            {
                     RegisterEmployee form =   new RegisterEmployee(null,null,null,null);
                     form.Owner = this;
                     form.Show();
            }
            else
            {
                MessageBox.Show("Usuário no existe!");
            }

           
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
           Login();

        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            var pass = sender as PasswordBox;
            loginViewModeL.Password = pass.Password;
        }
    }
}
