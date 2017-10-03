using Ninject;
using Ninject.Extensions.Factory;
using Ninject.Syntax;
using POSC.ModelsView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSC
{
public class NinjectUtil<Tn>
         where Tn : class
    {
        private IKernel container;

      
       public void ConfigureContainer()
        {
            this.container = new StandardKernel();
            container.Bind<Tn>().ToFactory();

        }

        public Tn ComposeObjects()

        {
        return (Tn) this.container.Get<Tn>();
        }

       
    }
}
