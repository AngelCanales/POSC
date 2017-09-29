using DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Contexts;

namespace DataBase.Repositories
{
    public class SectorRepository : RepositoryBase<Sector>
    {
        public SectorRepository(POSCContext context) : base(context)
        {
        }

        protected override Sector MapNewValuesToOld(Sector oldEntity, Sector newEntity)
        {
            oldEntity.Abbreviation = newEntity.Abbreviation;
            oldEntity.Address = newEntity.Address;
            oldEntity.Name = newEntity.Name;
            oldEntity.SectorId = newEntity.SectorId;
            return oldEntity;
        }
    }
}
