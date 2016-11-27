using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureTestApp.Startup))]
namespace AzureTestApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
