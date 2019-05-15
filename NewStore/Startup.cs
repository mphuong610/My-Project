using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewStore.Startup))]
namespace NewStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
