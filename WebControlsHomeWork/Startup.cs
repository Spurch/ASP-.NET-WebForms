using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebControlsHomeWork.Startup))]
namespace WebControlsHomeWork
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
