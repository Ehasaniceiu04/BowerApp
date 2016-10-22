using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BowerApp.Startup))]
namespace BowerApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
