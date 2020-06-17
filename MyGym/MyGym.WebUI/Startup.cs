using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyGym.WebUI.Startup))]
namespace MyGym.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
