using DataBase.Contexts;
using System.Data.Entity;

namespace POSC.Initializer
{
  public  class DropCreatePOSCContextIfModelChanges : CreateDatabaseIfNotExists<POSCContext>
    {
        protected override void Seed(POSCContext context)
        {
            POSCDevelopmentSeeder.Seed(context);
        }
    }
}
