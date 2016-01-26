using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MasterPagesCountriesHomework.Startup))]
namespace MasterPagesCountriesHomework
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
