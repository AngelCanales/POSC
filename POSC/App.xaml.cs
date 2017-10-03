using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

using Microsoft.AspNet.Identity.EntityFramework;

namespace POSC
{
    using DataBase.Contexts;
    using Initializer;
    using Ninject;
    using System.Data.Entity;
    using System.Windows;

    using Microsoft.AspNet.Identity.Owin;
    using Ninject.Extensions.Factory;
    using ModelsView;
    using View;
    using System.Linq;

    public partial class App : Application
    {
        private IKernel container;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ConfigureContainer();
            ComposeObjects();
            Current.MainWindow.Show();
        }

        private void ConfigureContainer()
        {
            this.container = new StandardKernel();
        container.Bind<POSCContext>().To<POSCContext>();
            container.Bind<DbContext>().To<POSCContext>();
        }

        private void ComposeObjects()

        {
           this.container.Get<POSCContext>().Customer.ToList();
            Current.MainWindow = this.container.Get<MainWindow>();
            Current.MainWindow.Title = "Punto de Venta POSC";
        }


    }
}
