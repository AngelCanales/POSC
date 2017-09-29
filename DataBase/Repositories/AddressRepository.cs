using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Repositories
{
    using Contexts;
    using Models;
    using System.Runtime.Remoting.Contexts;
    public class AddressRepository : RepositoryBase<Address>
    {
        public AddressRepository(POSCContext context)
            : base(context)
        {
        }

        protected override Address MapNewValuesToOld(Address oldEntity, Address newEntity)
        {
            oldEntity.Avenue = newEntity.Avenue;
            oldEntity.Boulevard = newEntity.Boulevard;
            oldEntity.References = newEntity.References;
            oldEntity.ResidentialArea = newEntity.ResidentialArea;
            oldEntity.Sector = newEntity.Sector;
            oldEntity.Street = newEntity.Street;
            oldEntity.DeliverPhone = newEntity.DeliverPhone;
            oldEntity.DeliverTo = newEntity.DeliverTo;
            return oldEntity;
        }
    }
}
