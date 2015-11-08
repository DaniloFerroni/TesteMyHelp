using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeesteWeb.Startup))]
namespace TeesteWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
