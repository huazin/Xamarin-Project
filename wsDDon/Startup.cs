using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(wsDDon.Startup))]
namespace wsDDon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
