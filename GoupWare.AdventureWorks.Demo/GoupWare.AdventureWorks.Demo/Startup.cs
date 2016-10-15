using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoupWare.AdventureWorks.Demo.Startup))]
namespace GoupWare.AdventureWorks.Demo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
