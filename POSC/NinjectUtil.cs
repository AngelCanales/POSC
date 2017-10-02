using Ninject;
using Ninject.Extensions.Factory;
using POSC.ModelsView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSC
{
public class NinjectUtil<T>
    {
        private IKernel container;
        private void ConfigureContainer<T>()
        {
            this.container = new StandardKernel();

            container.Bind<T>().ToFactory();
        }
    }
}
