using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CallCenterOS.Web.Startup))]
namespace CallCenterOS.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
