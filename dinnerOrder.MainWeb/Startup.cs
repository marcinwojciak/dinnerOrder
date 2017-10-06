using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dinnerOrder.MainWeb.Startup))]
namespace dinnerOrder.MainWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
