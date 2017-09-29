using DataBase.Contexts;
using DataBase.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using POSC.Initializer.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace POSC.Initializer
{
    public class POSCDevelopmentSeeder
    {
        public static void Seed(POSCContext context)
        {
            var role = context.Roles.FirstOrDefault((r => r.Name == "Administrator"));

            if (role == null)
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                role = new IdentityRole { Name = "Administrator" };
                manager.Create(role);
            }

            var role2 = context.Roles.FirstOrDefault((r => r.Name == "StoreCashier"));

            if (role2 == null)
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                role2 = new IdentityRole { Name = "StoreCashier" };
                manager.Create(role2);
            }
            var user1 = new ApplicationUser
            {
                UserName = "POSC@gmail.com",
                Email = "POSC@gmail.com",
            };
            var userManger = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var result = userManger.Create(user1, "Proyectos8@");
            context.SaveChanges();
            var u = userManger.FindByName("POSC@gmail.com");
            userManger.AddToRole(u.Id, "Administrator");
            context.SaveChanges();

            var user2 = new ApplicationUser
            {
                UserName = "POSCATM@gmail.com",
                Email = "POSCATM@gmail.com",
            };
            var userManger1 = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var result1 = userManger.Create(user2, "Proyectos8ATM@");
            context.SaveChanges();
            var u1 = userManger.FindByName("POSCATM@gmail.com");
            userManger.AddToRole(u1.Id, "StoreCashier");
            context.SaveChanges();

          
            var tax1 = new
                 Tax
            {
                Description = "15%",
                Percentage = Convert.ToDecimal(0.15)
            };

            var tax2 = new
                 Tax
            {
                Description = "18%",
                Percentage = Convert.ToDecimal(0.18)
            };

            var tax3 = new
                 Tax
            {
                Description = "0%",
                Percentage = 0
            };

            context.Tax.Add(tax1);
            context.Tax.Add(tax2);
            context.Tax.Add(tax3);

            var orderNumber = new OrderNumber
            {
                CurrenNumber = 0,
                LastNumber = 9999
            };
            context.OrderNumber.Add(orderNumber);

            var sector1 = new Sector
            {
                Name = "Northwest",
                Abbreviation = "NO"
            };
            context.Sector.Add(sector1);

            var sector2 = new Sector
            {
                Name = "NothEast",
                Abbreviation = "NE"
            };
            context.Sector.Add(sector2);

            var sector3 = new Sector
            {
                Name = "SouthEast",
                Abbreviation = "SE"
            };
            context.Sector.Add(sector3);

            var sector4 = new Sector
            {
                Name = "SouthWest",
                Abbreviation = "SO"
            };
            context.Sector.Add(sector4);

            var residentialArea1 = new ResidentialArea
            {
                Name = "Col. Dubón"
            };
            context.ResidentialArea.Add(residentialArea1);

            var residentialArea2 = new ResidentialArea
            {
                Name = "Col. Figueroa"
            };
            context.ResidentialArea.Add(residentialArea2);

            var residentialArea3 = new ResidentialArea
            {
                Name = "Col. Hernández"
            };
            context.ResidentialArea.Add(residentialArea3);

            var residentialArea4 = new ResidentialArea
            {
                Name = "Col. Altamira"
            };
            context.ResidentialArea.Add(residentialArea4);

            var residentialArea5 = new ResidentialArea
            {
                Name = "Col. Altiplano"
            };
            context.ResidentialArea.Add(residentialArea5);

            var residentialArea6 = new ResidentialArea
            {
                Name = "Col. La Puerta"
            };
            context.ResidentialArea.Add(residentialArea6);

            var residentialArea7 = new ResidentialArea
            {
                Name = "Sector La Puerta"
            };
            context.ResidentialArea.Add(residentialArea7);

            var residentialArea8 = new ResidentialArea
            {
                Name = "Blvd. Del Sur"
            };
            context.ResidentialArea.Add(residentialArea8);

            var residentialArea9 = new ResidentialArea
            {
                Name = "Barrio La Guardia"
            };
            context.ResidentialArea.Add(residentialArea9);

            var residentialArea10 = new ResidentialArea
            {
                Name = "Col. Prado Alto"
            };
            context.ResidentialArea.Add(residentialArea10);

            var residentialArea11 = new ResidentialArea
            {
                Name = "Col. La Trejo"
            };
            context.ResidentialArea.Add(residentialArea11);

            var residentialArea12 = new ResidentialArea
            {
                Name = "Col. La Chamelecon"
            };
            context.ResidentialArea.Add(residentialArea12);

            var residentialArea13 = new ResidentialArea
            {
                Name = "Barrio Paz Barahona"
            };
            context.ResidentialArea.Add(residentialArea13);

            var residentialArea14 = new ResidentialArea
            {
                Name = "Barrio Río de Piedras"
            };
            context.ResidentialArea.Add(residentialArea14);

            var residentialArea15 = new ResidentialArea
            {
                Name = "Col. Bellavista"
            };
            context.ResidentialArea.Add(residentialArea15);

            var residentialArea16 = new ResidentialArea
            {
                Name = "Barrio Suyapa"
            };
            context.ResidentialArea.Add(residentialArea16);

            var residentialArea17 = new ResidentialArea
            {
                Name = "Ave. Circumvalación Sur"
            };
            context.ResidentialArea.Add(residentialArea17);

            var residentialArea18 = new ResidentialArea
            {
                Name = "Ave. Circumvalación Norte"
            };
            context.ResidentialArea.Add(residentialArea18);

            var residentialArea19 = new ResidentialArea
            {
                Name = "Col. Moderna"
            };
            context.ResidentialArea.Add(residentialArea19);

            var residentialArea20 = new ResidentialArea
            {
                Name = "Barrio Los Andes"
            };
            context.ResidentialArea.Add(residentialArea20);

            var residentialArea21 = new ResidentialArea
            {
                Name = "Barrio Guamilito"
            };
            context.ResidentialArea.Add(residentialArea21);

            var residentialArea22 = new ResidentialArea
            {
                Name = "Col. La Mora"
            };
            context.ResidentialArea.Add(residentialArea22);

            var residentialArea23 = new ResidentialArea
            {
                Name = "Col. Zeron"
            };
            context.ResidentialArea.Add(residentialArea23);

            var residentialArea24 = new ResidentialArea
            {
                Name = "Barrio Santa Ana"
            };
            context.ResidentialArea.Add(residentialArea24);

            var residentialArea25 = new ResidentialArea
            {
                Name = "Col. Comlombia"
            };
            context.ResidentialArea.Add(residentialArea25);

            var residentialArea26 = new ResidentialArea
            {
                Name = "Barrio Las Acacias"
            };
            context.ResidentialArea.Add(residentialArea26);

            var residentialArea27 = new ResidentialArea
            {
                Name = "Barrio Las Flores"
            };
            context.ResidentialArea.Add(residentialArea27);

            var residentialArea28 = new ResidentialArea
            {
                Name = "Barrio Barandillas"
            };
            context.ResidentialArea.Add(residentialArea28);

            var residentialArea29 = new ResidentialArea
            {
                Name = "Zona Cervecería"
            };
            context.ResidentialArea.Add(residentialArea29);

            var residentialArea30 = new ResidentialArea
            {
                Name = "Zona Guadalupe"
            };
            context.ResidentialArea.Add(residentialArea30);

            var residentialArea31 = new ResidentialArea
            {
                Name = "Col. Univerdidad"
            };
            context.ResidentialArea.Add(residentialArea31);

            var residentialArea32 = new ResidentialArea
            {
                Name = "Col. Los Laureles"
            };
            context.ResidentialArea.Add(residentialArea32);

            var residentialArea33 = new ResidentialArea
            {
                Name = "Col. Jardines del valle"
            };
            context.ResidentialArea.Add(residentialArea33);

            var residentialArea34 = new ResidentialArea
            {
                Name = "Col. Villas del Sol"
            };
            context.ResidentialArea.Add(residentialArea34);

            var residentialArea35 = new ResidentialArea
            {
                Name = "Zona Pedregal"
            };
            context.ResidentialArea.Add(residentialArea35);

            var residentialArea36 = new ResidentialArea
            {
                Name = "Col. El Potosi"
            };
            context.ResidentialArea.Add(residentialArea36);

            var residentialArea37 = new ResidentialArea
            {
                Name = "Sector El Potosi"
            };
            context.ResidentialArea.Add(residentialArea37);

            var residentialArea38 = new ResidentialArea
            {
                Name = "Col. Juan Lindo"
            };
            context.ResidentialArea.Add(residentialArea38);

            var residentialArea39 = new ResidentialArea
            {
                Name = "Col. Buenos Aires"
            };
            context.ResidentialArea.Add(residentialArea39);

            var residentialArea40 = new ResidentialArea
            {
                Name = "Sector Bermejo"
            };
            context.ResidentialArea.Add(residentialArea40);

            var residentialArea41 = new ResidentialArea
            {
                Name = "Las Mesetas"
            };
            context.ResidentialArea.Add(residentialArea41);

            var residentialArea42 = new ResidentialArea
            {
                Name = "Col. Los Arcos"
            };
            context.ResidentialArea.Add(residentialArea42);

            var residentialArea43 = new ResidentialArea
            {
                Name = "Col. Bogran"
            };
            context.ResidentialArea.Add(residentialArea43);

            var residentialArea44 = new ResidentialArea
            {
                Name = "Sector Palenque"
            };
            context.ResidentialArea.Add(residentialArea44);

            var residentialArea45 = new ResidentialArea
            {
                Name = "Sector Palenque"
            };
            var sector5 = new Sector
            {
                Name = "SouthWest",
                Abbreviation = "SO"
            };
            var address = new Address
            {
                ResidentialArea = residentialArea45,
                Sector = sector5,
                Avenue = "",
                Boulevard = "",
                DeliverPhone = "",
                DeliverTo = "",
                References = "",
                Street = ""
            };

            var storer = new Store
            { Name = "Canales", Description = "la mejor tienda", Address = address};


            var employeesType =
                new EmployeesType
                {
                    Description = " Administrator de la tienda",
                    Name = "Administrator"
                };

            var employeesType1 =
               new EmployeesType
               {
                   Description = " Cajero de la tienda",
                   Name = "Cajero"
               };


            var EmployeesAdmin = new Employees
            {
                User = u,
                EmployeesType = employeesType,
                Store = storer
            };

            var EmployeesATM = new Employees
            {
                User = u1,
                EmployeesType = employeesType1,
                Store = storer,

            };
            context.Employees.Add(EmployeesAdmin);
            context.Employees.Add(EmployeesATM);
            var imagebaliada = Properties.Resources.descarga;
            var imagechef = Properties.Resources.descarga;
            var imagedrinks = Properties.Resources.descarga;
            var imageFit = Properties.Resources.descarga;

            var ProductsType1 = new ProductsType
            {
                Description = "WantChef",
                IsAdditional = false,
                Name = "Chef",
                Image = imagechef.ToByteArray()
            };

            var ProductsType2 = new ProductsType
            {
                Description = "WantTraditional",
                IsAdditional = false,
                Name = "Traditional",
                Image = imagebaliada.ToByteArray()
            };
            var ProductsType3 = new ProductsType
            {
                Description = "WantFit",
                IsAdditional = false,
                Name = "Fit",
                Image = imageFit.ToByteArray()
            };
            var ProductsType4 = new ProductsType
            {
                Description = "WantDrinks",
                IsAdditional = true,
                Name = "Drinks",
                Image = imagedrinks.ToByteArray()
            };

            var ProductsType5 = new ProductsType
            {
                Description = "WantDessert",
                IsAdditional = true,
                Name = "Dessert",
                Image = imagedrinks.ToByteArray()
            };

            var ProductsType7 = new ProductsType
            {
                Description = "Snacks",
                IsAdditional = true,
                Name = "Snacks",
                Image = imagedrinks.ToByteArray()
            };
            var ProductsType6 = new ProductsType
            {
                Description = "WantMiscellaneous",
                IsAdditional = true,
                Name = "Miscellaneous",
                Image = imagedrinks.ToByteArray()
            };

            context.ProductsType.Add(ProductsType1);
            context.ProductsType.Add(ProductsType2);
            context.ProductsType.Add(ProductsType3);
            context.ProductsType.Add(ProductsType4);
            context.ProductsType.Add(ProductsType5);
            context.ProductsType.Add(ProductsType7);
        //    context.ProductsType.Add(ProductsType6);

            var discount = new
               Discount
            {
                Description = "15%",
                Percentage = Convert.ToDecimal(0.15)
            };
            var productima = new ProductsImage {Image= imagedrinks.ToByteArray(),ImageType=ImageType.Jpg };
            var Tax5 = new
              Tax
            {
                Description = "15%",
                Percentage = Convert.ToDecimal(0.15)
            };
            var supp = new Suppliers
            {
                ContactName="jose",
                Name="Cerveceria",
                PhoneContactName="9999",
                PhoneSuppliers="234223",
                RTN="2342354325345"
                
            };
            var product = new Products
            {
                Barcode = "ssdrew4r234",
                Cost = 45,
                Description = "werweterwt",
                Discount = discount,
                ExpirationDate = DateTime.Today.AddDays(50),
                IsActive = true,
                Name = "Coca",
                Price = 65,
                ProductsType = ProductsType6,
                Tax=Tax5,
                ProductsImage=productima,
                Suppliers=supp

            };

            var fiscalData1 = new FiscalData
            {
                FirstInvoiceNumber = 1,
                LastInvoiceNumber = 4500,
                DocumentType = 1,
                EmissionPoint = 0,
                Establishment = 1,
                CurrenInvoiceNumber = 1,
                PrintCode = "438096-072724-F94CB5-E1AB62-39F534-8D",
                ValidUntilDate = DateTime.Today.AddDays(50),
                Store = storer
            };

            context.FiscalData.Add(fiscalData1);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                // TODO: LOGS
                throw;
            }
        }
    }
}
