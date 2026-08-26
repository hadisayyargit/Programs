using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shayatech.Startup))]
namespace Shayatech
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
