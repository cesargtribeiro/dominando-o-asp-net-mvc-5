using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CesarRibeiro.AppMvc.Startup))]
namespace CesarRibeiro.AppMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
