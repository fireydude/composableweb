using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ComposableWeb.Startup))]
namespace ComposableWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
