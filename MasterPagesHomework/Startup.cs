using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MasterPagesHomework.Startup))]
namespace MasterPagesHomework
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
