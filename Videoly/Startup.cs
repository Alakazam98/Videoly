using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Videoly.Startup))]
namespace Videoly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
