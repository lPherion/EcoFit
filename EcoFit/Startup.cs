using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EcoFit.Startup))]
namespace EcoFit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
