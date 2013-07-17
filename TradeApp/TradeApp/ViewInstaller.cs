using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using GalaSoft.MvvmLight;

namespace TradeApp
{
    public class ViewInstaller : IWindsorInstaller 
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly()
                                     .BasedOn<IView>().WithServiceSelf().LifestyleTransient());
        }
    }

    public interface IView
    {
        //just a marker
    }

    public class ViewModelInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly()
                                     .BasedOn<ViewModelBase>().WithServiceSelf().LifestyleTransient());
        }
    }
}