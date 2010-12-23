using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace TypedFactoryExample.Configuration.Installers
{
    public class ViewInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(AllTypes.FromThisAssembly().BasedOn<IView>()
                                   .Configure(c => c.LifeStyle.Transient)
                                   .WithService.AllInterfaces());
        }
    }
}