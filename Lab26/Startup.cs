using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GCIdentity.Startup))]
namespace GCIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
