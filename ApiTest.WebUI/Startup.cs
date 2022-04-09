using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApiTest.WebUI.Startup))]
namespace ApiTest.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
