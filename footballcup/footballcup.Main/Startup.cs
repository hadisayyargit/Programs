using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(footballcup.Startup))]
namespace footballcup
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);            
            app.MapSignalR();



        }
    }
}
