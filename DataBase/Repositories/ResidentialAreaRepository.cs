using DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Contexts;

namespace DataBase.Repositories
{
    public class ResidentialAreaRepository : RepositoryBase<ResidentialArea>
    {
        public ResidentialAreaRepository(POSCContext context) : base(context)
        {
        }

        protected override ResidentialArea MapNewValuesToOld(ResidentialArea oldEntity, ResidentialArea newEntity)
        {
            oldEntity.Address = newEntity.Address;
            oldEntity.Name = newEntity.Name;
            oldEntity.ResidentialAreaId = newEntity.ResidentialAreaId;
            return oldEntity;
        }
    }
}
