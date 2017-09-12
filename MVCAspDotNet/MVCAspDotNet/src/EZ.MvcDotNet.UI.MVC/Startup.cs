using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EZ.MvcDotNet.UI.MVC.Startup))]
namespace EZ.MvcDotNet.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
