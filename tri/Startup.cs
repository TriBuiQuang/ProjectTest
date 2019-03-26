using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tri.Startup))]
namespace tri
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
