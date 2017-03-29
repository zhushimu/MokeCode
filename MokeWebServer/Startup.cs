using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MokeWebServer.Startup))]
namespace MokeWebServer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
