using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SSCSSConfig.Startup))]
namespace SSCSSConfig
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
