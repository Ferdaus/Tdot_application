using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tdot_application.Startup))]
namespace Tdot_application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
