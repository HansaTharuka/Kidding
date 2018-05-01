using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kidding.Startup))]
namespace Kidding
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
