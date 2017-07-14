using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AVObserver.Startup))]
namespace AVObserver
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
