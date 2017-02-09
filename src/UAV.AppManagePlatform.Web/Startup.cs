using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UAV.AppManagePlatform.Web.Startup))]
namespace UAV.AppManagePlatform.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
