using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Contexts;
using DataBase.Models;

namespace DataBase.Repositories
{
    public class UsersRepository : RepositoryBase<ApplicationUser>
    {
        public UsersRepository(POSCContext context) : base(context)
        {
        }

        protected override ApplicationUser MapNewValuesToOld(ApplicationUser oldEntity, ApplicationUser newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
