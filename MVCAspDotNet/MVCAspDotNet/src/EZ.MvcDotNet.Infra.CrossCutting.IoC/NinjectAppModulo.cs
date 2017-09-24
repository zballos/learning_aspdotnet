using EZ.MvcDotNet.Application;
using EZ.MvcDotNet.Application.Interface;
using Ninject.Modules;

namespace EZ.MvcDotNet.Infra.CrossCutting.IoC
{
    public class NinjectAppModulo : NinjectModule
    {
        public override void Load()
        {
            // Application
            Bind<IClienteAppService>().To<ClienteAppService>();
        }
    }
}