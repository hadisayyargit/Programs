using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShakelliReportsUI.Main.Startup))]
namespace ShakelliReportsUI.Main
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
