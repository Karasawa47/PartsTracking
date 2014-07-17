using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PartsTracker.Startup))]
namespace PartsTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
