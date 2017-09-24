using Ninject;

namespace EZ.MvcDotNet.Infra.CrossCutting.IoC
{
    public class Container
    {
        public StandardKernel GetModule()
        {
            return new StandardKernel(new NinjectModulo(), new NinjectAppModulo());
        }
    }
}