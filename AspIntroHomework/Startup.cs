using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspIntroHomework.Startup))]
namespace AspIntroHomework
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
