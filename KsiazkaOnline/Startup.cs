using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KsiazkaOnline.Startup))]
namespace KsiazkaOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
