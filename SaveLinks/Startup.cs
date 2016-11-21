using Microsoft.Owin;
using Owin;
using SaveLinks;

[assembly: OwinStartup(typeof(Startup))]
namespace SaveLinks
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
