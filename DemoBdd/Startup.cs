using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoBdd.Startup))]
namespace DemoBdd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
