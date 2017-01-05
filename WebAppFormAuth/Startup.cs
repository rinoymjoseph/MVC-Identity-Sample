using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppFormAuth.Startup))]
namespace WebAppFormAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
