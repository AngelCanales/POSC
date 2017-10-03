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
using Ninject;
using Ninject.Extensions.Factory;

namespace POSC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly LoginViewModeL loginViewModeL;
        UserManager<IdentityUser> userManager;


        public MainWindow() { 

           

            userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(new IdentityDbContext("POSC")));
            this.loginViewModeL = new LoginViewModeL();
            loginViewModeL.Email = "POSC@gmail.com";
            loginViewModeL.Password = "Proyectos8@";
            this.DataContext = loginViewModeL;
            InitializeComponent();
        }

        public void Login()
        {

            var user = userManager.Find(loginViewModeL.Email, loginViewModeL.Password);
            
            if (user != null)
            {
                var obj = new NinjectUtil<RegisterEmployee, RegisterEmployeeViewModel>();
                RegisterEmployee form = obj.ComposeObjects(); //new RegisterEmployee();
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
            loginViewModeL.Password = "Proyectos8@";// pass.Password;
        }
    }
}
