using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITBDUF.Startup))]
namespace ITBDUF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
