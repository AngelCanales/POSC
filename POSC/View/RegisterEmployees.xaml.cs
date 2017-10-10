using DataBase.Contexts;
using DataBase.Models;
using Logic.Logic;
using Ninject;
using Ninject.Extensions.Factory;
using POSC.ModelsView;
using POSC.UserControls;
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
using DataBase.Models;
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
        private readonly EmployeesLogic employeesLogic;


        public RegisterEmployee(EmployeesTypeLogic employeesTypeLogic, StoreLogic storeLogic, ResidentialAreaLogic residentialAreaLogic, SectorLogic sectorLogic, EmployeesLogic employeesLogic)
        {
            this.sectorLogic = sectorLogic;
            this.residentialAreaLogic = residentialAreaLogic;
            this.storeLogic = storeLogic;
            this.employeesTypeLogic = employeesTypeLogic;
            this.employeesLogic = employeesLogic;
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
            var sectors = sectorLogic.GetSector(registerEmployeeViewModel.SectorID);
            var residentialArea = residentialAreaLogic.GetResidentialArea(registerEmployeeViewModel.ResidentialAreaID);
            var store = storeLogic.GetStore(registerEmployeeViewModel.StoreId);
            var employeesTypes = employeesTypeLogic.GetEmployeesType(registerEmployeeViewModel.EmployeesTypeID);
            var y = registerEmployeeViewModel.Password;
            var address = new DataBase.Models.Address
            {
                Avenue = registerEmployeeViewModel.Avenue,
                ResidentialArea = residentialArea,
                Boulevard =  registerEmployeeViewModel.Boulevard,
                DeliverPhone = registerEmployeeViewModel.PhoneNumber2,
                DeliverTo = registerEmployeeViewModel.ContactName,
                References = registerEmployeeViewModel.References,
                Sector = sectors,
                Street =  registerEmployeeViewModel.Street,
            };
            var employees = new Employees();
            employees.Address = address;
            employees.ContactName = registerEmployeeViewModel.ContactName;
            employees.Name = registerEmployeeViewModel.Name;
            employees.PhoneNumber1 = registerEmployeeViewModel.PhoneNumber1;
            employees.PhoneNumber2 = registerEmployeeViewModel.PhoneNumber2;
            employees.RTN = registerEmployeeViewModel.RTN;
            employees.Store = store;
            employees.User = null;
            employees.UserId = null;
            employees.EmployeesType = employeesTypes;


        }
    }
}
