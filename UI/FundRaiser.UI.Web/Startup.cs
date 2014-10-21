using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FundRaiser.UI.Web.Startup))]
namespace FundRaiser.UI.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
