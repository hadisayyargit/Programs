using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SazianPayesh.Startup))]
namespace SazianPayesh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
