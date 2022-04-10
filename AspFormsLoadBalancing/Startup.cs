using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspFormsLoadBalancing.Startup))]
namespace AspFormsLoadBalancing
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
