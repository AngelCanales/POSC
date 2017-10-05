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
public class NinjectUtil<Tn,Tm>
         where Tn : class
         where Tm : class
    {
        private IKernel container;

        public NinjectUtil()
        {
            ConfigureContainer();
        }
       public void ConfigureContainer()
        {
            this.container = new StandardKernel();
            container.Bind<Tm>().ToFactory();

        }

        public Tn ComposeObjects()

        {
        return (Tn) this.container.Get<Tn>();
        }

       
    }
}
