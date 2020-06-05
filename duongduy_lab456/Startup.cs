using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(duongduy_lab456.Startup))]
namespace duongduy_lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
