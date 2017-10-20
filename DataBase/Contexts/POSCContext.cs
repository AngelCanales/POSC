using DataBase.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Contexts
{
  public  class POSCContext : IdentityDbContext<ApplicationUser>
    {
       static POSCContext()
        {
                
        }

        public POSCContext() : base("POSC")
        {
            this.Database.Log = s => Debug.Write(s);
        }

        public DbSet<OrderDetail> OD { get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<Invoice> Invoice { get; set; }

        public DbSet<FiscalData> FiscalData { get; set; }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Products> Products { get; set; }

        public DbSet<Address> Address { get; set; }

        public DbSet<Tax> Tax { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<EmployeesType> EmployeesType { get; set; }

        public DbSet<ProductsType> ProductsType { get; set; }

        public DbSet<ProductsImage> ProductsImage { get; set; }

        public DbSet<OrderNumber> OrderNumber { get; set; }

        public DbSet<Sector> Sector { get; set; }

        public DbSet<ResidentialArea> ResidentialArea { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

      
            modelBuilder.Entity<OrderDetail>();
            modelBuilder.Entity<Tax>().HasKey(t => t.TaxId);
            modelBuilder.Entity<FiscalData>();
            modelBuilder.Entity<OrderNumber>();
            modelBuilder.Entity<Address>();

            modelBuilder.Entity<Discount>();
            modelBuilder.Entity<Suppliers>();

            modelBuilder.Entity<Purchases>().HasKey(p => p.Id);
            modelBuilder.Entity<PurchasesDetail>()
                .HasKey(pd => new { pd.ProductsId, pd.EntryDate, pd.IdLine, pd.PurchasesId });
           
            modelBuilder.Entity<PurchasesDetail>().HasRequired(d => d.Purchases);
            modelBuilder.Entity<PurchasesDetail>().HasRequired(o => o.Products);

            modelBuilder.Entity<Store>();
            modelBuilder.Entity<Inventory>();

            modelBuilder.Entity<Sector>().HasKey(s => s.SectorId);
            modelBuilder.Entity<Customer>();
            modelBuilder.Entity<Employees>();
            modelBuilder.Entity<EmployeesType>();
            modelBuilder.Entity<Order>().HasKey(o => o.OrderId);
            modelBuilder.Entity<OrderDetail>()
                .HasKey(od => new { od.ProductsId, od.OrderId, od.DeliveryDate,od.IdLine });
            modelBuilder.Entity<OrderDetail>().HasRequired(od => od.Order);
            modelBuilder.Entity<OrderDetail>().HasRequired(od => od.Products);

            base.OnModelCreating(modelBuilder);
        }
    }
}
