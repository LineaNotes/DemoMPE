using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoMPE.Startup))]
namespace DemoMPE
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
