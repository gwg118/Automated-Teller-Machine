using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Automated_Teller_Machine.Startup))]
namespace Automated_Teller_Machine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
