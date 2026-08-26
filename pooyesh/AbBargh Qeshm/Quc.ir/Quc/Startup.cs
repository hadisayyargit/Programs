using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(quc.Startup))]
namespace quc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
