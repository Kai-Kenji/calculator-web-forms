using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webseite_Taschenrechner_3.Startup))]
namespace Webseite_Taschenrechner_3
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
