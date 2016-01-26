using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspMvcSampleApp.Startup))]
namespace AspMvcSampleApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
