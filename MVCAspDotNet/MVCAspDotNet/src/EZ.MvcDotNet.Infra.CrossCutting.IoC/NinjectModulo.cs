using EZ.MvcDotNet.Application;
using EZ.MvcDotNet.Application.Interface;
using EZ.MvcDotNet.Domain.Interfaces.Repository;
using EZ.MvcDotNet.Domain.Interfaces.Services;
using EZ.MvcDotNet.Domain.Services;
using EZ.MvcDotNet.Infra.Data.Context;
using EZ.MvcDotNet.Infra.Data.Interfaces;
using EZ.MvcDotNet.Infra.Data.Repository;
using EZ.MvcDotNet.Infra.Data.UoW;
using Ninject.Modules;

namespace EZ.MvcDotNet.Infra.CrossCutting.IoC
{
    public class NinjectModulo : NinjectModule
    {
        public override void Load()
        {
            // Camada de aplicação tem essas dependencias
            
            // Domain
            Bind<IClienteService>().To<ClienteService>();

            // Data
            Bind<IClienteRepository>().To<ClienteRepository>();
            //Bind(typeof(IRepository<>)).To(typeof(Repository<>));

            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind<IContextManager>().To<ContextManager>();
        }
    }
}