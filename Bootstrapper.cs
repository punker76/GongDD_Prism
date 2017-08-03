using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GongDD_PrismRegion
{
    class Bootstrapper : UnityBootstrapper
    {

      
        protected override DependencyObject CreateShell()
        {
          
            MainWindow myShell = Container.Resolve<MainWindow>();
            Container.RegisterInstance(typeof(Window), myShell, new ContainerControlledLifetimeManager());
            return Container.Resolve<Window>();
            
        }

        protected override void InitializeShell()
        {


            base.InitializeShell();

            // Register views
            var regionManager = this.Container.Resolve<IRegionManager>();
            if (regionManager != null)
            {

                regionManager.AddToRegion("PrismRegion", "[ITEM A]");
                regionManager.AddToRegion("PrismRegion", "[ITEM B]");
                regionManager.AddToRegion("PrismRegion", "[ITEM C]");
                regionManager.AddToRegion("PrismRegion", "[ITEM D]");
                regionManager.AddToRegion("PrismRegion", "[ITEM E]");
            }

            Application.Current.MainWindow.Show();
        }


    }
}
