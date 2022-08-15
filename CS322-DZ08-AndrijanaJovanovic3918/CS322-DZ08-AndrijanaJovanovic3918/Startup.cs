using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CS322_DZ08_AndrijanaJovanovic3918.Startup))]
namespace CS322_DZ08_AndrijanaJovanovic3918
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
