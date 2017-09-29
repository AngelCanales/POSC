using DataBase.Contexts;
using DataBase.Models;
using DataBase.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using POSC.Data.Repositories;
namespace DataBase.UnitOfWork
{
  public  class POSCUnitOfWork : IDisposable
    {
        private POSCContext context;

        private IRepository<Address> addressRepository;
        private IRepository<Customer> customerRepository;
        private IRepository<Products> dishRepository;
        private IRepository<FiscalData> fiscalDataRepository;
        private IRepository<Invoice> invoiceRepository;
        private IRepository<OrderDetail> orderDetailRepository;
        private IRepository<Order> orderRepository;
        private IRepository<Tax> taxRepository;
        private IRepository<ProductsType> dishTypeRepository;
        private IRepository<ApplicationUser> userRepository;
        private IRepository<ProductsImage> dishImageRepository;
        private IRepository<OrderNumber> orderNumberRepository;
        private IRepository<Sector> sectorRepository;
        private IRepository<ResidentialArea> residentialAreaRepository;
        private IRepository<Employees> employeesRepository;
        private IRepository<EmployeesType> employeesTypeRepository;

        private IRepository<Store> storeRepository;
        private IRepository<Discount> discountRepository;
        private IRepository<Inventory> inventoryRepository;
        private IRepository<Purchases> purchasesRepository;
        private IRepository<PurchasesDetail> purchasesDetailRepository;
        private IRepository<Suppliers> suppliersRepository;

        public POSCUnitOfWork(POSCContext context)
        {
            this.context = context;
        }

        public IRepository<Purchases> PurchasesRepository
        {
            get
            {
                if (this.purchasesRepository == null)
                {
                    this.purchasesRepository = new PurchasesRepository(this.context);
                }

                return this.purchasesRepository;
            }
        }
        public IRepository<PurchasesDetail> PurchasesDetailRepository
        {
            get
            {
                if (this.purchasesDetailRepository == null)
                {
                    this.purchasesDetailRepository = new PurchasesDetailRepository(this.context);
                }

                return this.purchasesDetailRepository;
            }
        }
        public IRepository<Suppliers> SuppliersRepository
        {
            get
            {
                if (this.suppliersRepository == null)
                {
                    this.suppliersRepository = new SuppliersRepository(this.context);
                }

                return this.suppliersRepository;
            }
        }
        public IRepository<Store> StoreRepository
        {
            get
            {
                if (this.storeRepository == null)
                {
                    this.storeRepository = new StoreRepository(this.context);
                }

                return this.storeRepository;
            }
        }
        public IRepository<Discount> DiscountRepository
        {
            get
            {
                if (this.discountRepository == null)
                {
                    this.discountRepository = new DiscountRepository(this.context);
                }

                return this.discountRepository;
            }
        }
        public IRepository<Inventory> InventoryRepository
        {
            get
            {
                if (this.inventoryRepository == null)
                {
                    this.inventoryRepository = new InventoryRepository(this.context);
                }

                return this.inventoryRepository;
            }
        }

        public IRepository<Address> AddressRepository
        {
            get
            {
                if (this.addressRepository == null)
                {
                    this.addressRepository = new AddressRepository(this.context);
                }

                return this.addressRepository;
            }
        }

        public IRepository<Employees> EmployeesRepository
        {
            get
            {
                if (this.employeesRepository == null)
                {
                    this.employeesRepository = new EmployeesRepository(this.context);
                }

                return this.employeesRepository;
            }
        }

        public IRepository<EmployeesType> EmployeesTypeRepository
        {
            get
            {
                if (this.employeesTypeRepository == null)
                {
                    this.employeesTypeRepository = new EmployeesTypeRepository(this.context);
                }

                return this.employeesTypeRepository;
            }
        }
        public IRepository<ProductsType> DishTypeRepository
        {
            get
            {
                if (this.dishTypeRepository == null)
                {
                    this.dishTypeRepository = new ProductsTypeRepository(this.context);
                }

                return this.dishTypeRepository;
            }
        }

        public IRepository<Customer> CustomerRepository
        {
            get
            {
                if (this.customerRepository == null)
                {
                    this.customerRepository = new CustomerRepository(this.context);
                }

                return this.customerRepository;
            }
        }

        public IRepository<Products> DishRepository
        {
            get
            {
                if (this.dishRepository == null)
                {
                    this.dishRepository = new ProductsRepository(this.context);
                }

                return this.dishRepository;
            }
        }

        public IRepository<FiscalData> FiscalDataRepository
        {
            get
            {
                if (this.fiscalDataRepository == null)
                {
                    this.fiscalDataRepository = new FiscalDataRepository(this.context);
                }

                return this.fiscalDataRepository;
            }
        }

        public IRepository<Invoice> InvoiceRepository
        {
            get
            {
                if (this.invoiceRepository == null)
                {
                    this.invoiceRepository = new InvoiceRepository(this.context);
                }

                return this.invoiceRepository;
            }
        }

        public IRepository<OrderDetail> OrderDetailRepository
        {
            get
            {
                if (this.orderDetailRepository == null)
                {
                    this.orderDetailRepository = new OrderDetailRepository(this.context);
                }

                return this.orderDetailRepository;
            }
        }

        public IRepository<Order> OrderRepository
        {
            get
            {
                if (this.orderRepository == null)
                {
                    this.orderRepository = new OrderRepository(this.context);
                }

                return this.orderRepository;
            }
        }

        public IRepository<Tax> TaxRepository
        {
            get
            {
                if (this.taxRepository == null)
                {
                    this.taxRepository = new TaxRepository(this.context);
                }

                return this.taxRepository;
            }
        }

        public IRepository<ApplicationUser> UserRepository
        {
            get
            {
                if (this.userRepository == null)
                {
                    this.userRepository = new UsersRepository(this.context);
                }

                return this.userRepository;
            }
        }

        public IRepository<ProductsImage> DishImageRepository
        {
            get
            {
                if (this.dishImageRepository == null)
                {
                    this.dishImageRepository = new ProductsImageRepository(this.context);
                }

                return this.dishImageRepository;
            }
        }

        public IRepository<OrderNumber> OrderNumberRepository
        {
            get
            {
                if (this.orderNumberRepository == null)
                {
                    this.orderNumberRepository = new OrderNumberRepository(this.context);
                }

                return this.orderNumberRepository;
            }
        }

        public IRepository<Sector> SectorRepository
        {
            get
            {
                if (this.sectorRepository == null)
                {
                    this.sectorRepository = new SectorRepository(this.context);
                }

                return this.sectorRepository;
            }
        }

        public IRepository<ResidentialArea> ResidentialAreaRepository
        {
            get
            {
                if (this.residentialAreaRepository == null)
                {
                    this.residentialAreaRepository = new ResidentialAreaRepository(this.context);
                }

                return this.residentialAreaRepository;
            }
        }

        public void Dispose()
        {
            this.context.Dispose();
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        public Task SaveChangesAsync()
        {
            return this.context.SaveChangesAsync();
        }
    }
}

