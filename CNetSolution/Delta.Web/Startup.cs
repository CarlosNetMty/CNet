using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Delta.Web.Startup))]
namespace Delta.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
