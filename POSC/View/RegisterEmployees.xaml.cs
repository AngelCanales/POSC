using DataBase.Contexts;
using DataBase.Models;
using Logic.Logic;
using Ninject;
using Ninject.Extensions.Factory;
using POSC.ModelsView;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace POSC.View
{
    /// <summary>
    /// Interaction logic for RegisterEmployee.xaml
    /// </summary>
    public partial class RegisterEmployee : Window
    {
        private readonly RegisterEmployeeViewModel registerEmployeeViewModel;
        private readonly EmployeesTypeLogic employeesTypeLogic;
        private readonly StoreLogic storeLogic;
        private readonly ResidentialAreaLogic residentialAreaLogic;
        private readonly SectorLogic sectorLogic;

       
        public RegisterEmployee(EmployeesTypeLogic employeesTypeLogic, StoreLogic storeLogic, ResidentialAreaLogic residentialAreaLogic, SectorLogic sectorLogic)
        {
            this.sectorLogic = sectorLogic;
            this.residentialAreaLogic = residentialAreaLogic;
            this.storeLogic = storeLogic;
            this.employeesTypeLogic = employeesTypeLogic;
            var x = sectorLogic.GetAll();
     
            this.registerEmployeeViewModel = new RegisterEmployeeViewModel();
            registerEmployeeViewModel.Sector = x;
            registerEmployeeViewModel.Store = storeLogic.GetAll();
            registerEmployeeViewModel.ResidentialArea = residentialAreaLogic.GetAll().ToList();
            registerEmployeeViewModel.EmployeesType = employeesTypeLogic.GetAll().ToList();
            this.DataContext = registerEmployeeViewModel;
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var x = registerEmployeeViewModel;
         }
    }
}
