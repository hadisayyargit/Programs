using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(shahriarco.Anbar.Startup))]
namespace shahriarco.Anbar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
