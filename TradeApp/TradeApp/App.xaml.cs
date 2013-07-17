using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Castle.Windsor;

namespace TradeApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static IWindsorContainer container ;
        
        public App()
        {
            container = new WindsorContainer();
            container.Install(new ViewModelInstaller(), new ViewInstaller());
        }

        public static IWindsorContainer Container { get { return container; } }
        
    }
}
